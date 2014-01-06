using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Util;

namespace DroughtsDotNet.Game {

    /// <summary>
    /// View für einen Spielstein
    /// </summary>
    internal class TokenView : ModelVisual3D {
        /// <summary>
        /// DependencyProperty für die Höhe des Spielsteins
        /// </summary>
        public static readonly DependencyProperty ThetaDivProperty =
            DependencyProperty.Register("ThetaDiv", typeof(int), typeof(TokenView), new PropertyMetadata(1000));

        /// <summary>
        /// DependencyProperty für die Farbe des Spielsteins
        /// </summary>
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(SolidColorBrush), typeof(TokenView), new PropertyMetadata());

        /// <summary>
        /// DependencyProperty für die Position des Spielsteins
        /// </summary>
        public static readonly DependencyProperty PositionProperty =
            DependencyProperty.Register("Position", typeof(Point3D), typeof(TokenView), new PropertyMetadata());

        /// <summary>
        /// DependencyProperty für den äußeren Radius des Spielsteins
        /// </summary>
        public static readonly DependencyProperty RadiusProperty =
            DependencyProperty.Register("Radius", typeof(double), typeof(TokenView), new PropertyMetadata());

        /// <summary>
        /// DependencyProperty für die Höhe des Spielsteins
        /// </summary>
        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register("Height", typeof(double), typeof(TokenView), new PropertyMetadata(0.1));

        /// <summary>
        /// DependencyProperty für die Höhe des Spielsteins
        /// </summary>
        public static readonly DependencyProperty OuterCircleRadiusRatioProperty =
            DependencyProperty.Register("Height", typeof(double), typeof(TokenView), new PropertyMetadata());

        /// <summary>
        /// DependencyProperty für die Höhe des Spielsteins
        /// </summary>
        public static readonly DependencyProperty OuterCircleHeightRatioProperty =
            DependencyProperty.Register("Height", typeof(double), typeof(TokenView), new PropertyMetadata());

        /// <summary>
        /// DependencyProperty für die Höhe des Spielsteins
        /// </summary>
        public static readonly DependencyProperty InnerCircleRadiusRatioProperty =
            DependencyProperty.Register("Height", typeof(double), typeof(TokenView), new PropertyMetadata());

        /// <summary>
        /// Liefert oder setzt die Anzahl der Ecken, die der Spielstein aufweist.
        /// </summary>
        public int ThetaDiv {
            get {
                return (int)this.GetValue(ThetaDivProperty);
            }
            set {
                this.SetValue(ThetaDivProperty, value);
            }
        }

        public double Radius {
            get {
                return (double)this.GetValue(RadiusProperty);
            }
            set {
                this.SetValue(RadiusProperty, value);
            }
        }

        /// <summary>
        /// Liefert oder setzt die Höhe des Spielsteins.
        /// </summary>
        public double Height {
            get {
                return (double)this.GetValue(HeightProperty);
            }
            set {
                this.SetValue(HeightProperty, value);
            }
        }

        /// <summary>
        /// Erzeugt die Geometrie des Spielsteins
        /// </summary>
        /// <returns></returns>
        private MeshGeometry3D CreateMesh() {
            double innerWidth = this.Radius - (this.Radius / 6);
            double edgeWidth = this.Height / 7;
            double middleHeigth = this.Height / 3;
            double width3 = innerWidth / 1;
            double firstHuckelWidth = this.Radius / 2;
            double firstHuckelWidthAll = this.Radius / 10;
            double firstHuckelHeight = middleHeigth / 2;
            Point3D originin = new Point3D(0.5, 0.01, 0.5);
            double degrees = 360;

            double deltaTheta = (degrees - (degrees / this.ThetaDiv)).DegreeToRadian() / this.ThetaDiv;

            MeshGeometry3D mesh = new MeshGeometry3D();

            int factor = 14;
            for(int thetaI = 0; thetaI <= this.ThetaDiv; thetaI++) {
                double theta = thetaI * deltaTheta;
                double thetaSin = Math.Sin(theta);
                double thetaCos = Math.Cos(theta);

                mesh.Positions.Add(
                    new Point3D(this.Radius * thetaSin + originin.X, this.Height + originin.Y, this.Radius * thetaCos + originin.Z));
                mesh.Positions.Add(
                    new Point3D(this.Radius * thetaSin + originin.X, -this.Height + originin.Y, this.Radius * thetaCos + originin.Z));
                mesh.Normals.Add(new Vector3D(thetaSin, 1, thetaCos));
                mesh.Normals.Add(new Vector3D(thetaSin, -1, thetaCos));

                mesh.Positions.Add(
                    new Point3D(innerWidth * thetaSin + originin.X, this.Height + originin.Y, innerWidth * thetaCos + originin.Z));
                mesh.Positions.Add(
                    new Point3D(innerWidth * thetaSin + originin.X, -this.Height + originin.Y, innerWidth * thetaCos + originin.Z));
                mesh.Normals.Add(new Vector3D(-thetaSin, 1, -thetaCos));
                mesh.Normals.Add(new Vector3D(-thetaSin, -1, -thetaCos));

                mesh.Positions.Add(
                    new Point3D(width3 * thetaSin + originin.X, middleHeigth + originin.Y, width3 * thetaCos + originin.Z));
                mesh.Positions.Add(
                    new Point3D(width3 * thetaSin + originin.X, -middleHeigth + originin.Y, width3 * thetaCos + originin.Z));
                mesh.Normals.Add(new Vector3D(-thetaSin, 1, -thetaCos));
                mesh.Normals.Add(new Vector3D(-thetaSin, -1, -thetaCos));

                mesh.Positions.Add(
                    new Point3D(firstHuckelWidth * thetaSin + originin.X, middleHeigth + originin.Y, firstHuckelWidth * thetaCos + originin.Z));
                mesh.Positions.Add(
                    new Point3D(firstHuckelWidth * thetaSin + originin.X, -middleHeigth + originin.Y, firstHuckelWidth * thetaCos + originin.Z));
                mesh.Normals.Add(new Vector3D(thetaSin, 5, thetaCos));
                mesh.Normals.Add(new Vector3D(thetaSin, -5, thetaCos));

                mesh.Positions.Add(
                    new Point3D(firstHuckelWidth * thetaSin + originin.X, middleHeigth + firstHuckelHeight + originin.Y, firstHuckelWidth * thetaCos + originin.Z));
                mesh.Positions.Add(
                    new Point3D(firstHuckelWidth * thetaSin + originin.X, -middleHeigth - firstHuckelHeight + originin.Y, firstHuckelWidth * thetaCos + originin.Z));
                mesh.Normals.Add(new Vector3D(thetaSin, 1, thetaCos));
                mesh.Normals.Add(new Vector3D(thetaSin, -1, thetaCos));

                mesh.Positions.Add(
                    new Point3D((firstHuckelWidth - firstHuckelWidthAll) * thetaSin + originin.X, middleHeigth + firstHuckelHeight + originin.Y, (firstHuckelWidth - firstHuckelWidthAll) * thetaCos + originin.Z));
                mesh.Positions.Add(
                    new Point3D((firstHuckelWidth - firstHuckelWidthAll) * thetaSin + originin.X, -middleHeigth - firstHuckelHeight + originin.Y, (firstHuckelWidth - firstHuckelWidthAll) * thetaCos + originin.Z));
                mesh.Normals.Add(new Vector3D(-thetaSin, 1, -thetaCos));
                mesh.Normals.Add(new Vector3D(-thetaSin, -1, -thetaCos));

                mesh.Positions.Add(
                    new Point3D((firstHuckelWidth - firstHuckelWidthAll) * thetaSin + originin.X, middleHeigth + originin.Y, (firstHuckelWidth - firstHuckelWidthAll) * thetaCos + originin.Z));
                mesh.Positions.Add(
                    new Point3D((firstHuckelWidth - firstHuckelWidthAll) * thetaSin + originin.X, -middleHeigth + originin.Y, (firstHuckelWidth - firstHuckelWidthAll) * thetaCos + originin.Z));
                mesh.Normals.Add(new Vector3D(-thetaSin, 1, -thetaCos));
                mesh.Normals.Add(new Vector3D(-thetaSin, -1, -thetaCos));
            }

            // Zwei punkte in der Mitte
            mesh.Positions.Add(
                   new Point3D(originin.X, middleHeigth + originin.Y, originin.Z));
            mesh.Positions.Add(
                new Point3D(originin.X, -middleHeigth + originin.Y, originin.Z));
            mesh.Normals.Add(new Vector3D(0, 1, 0));
            mesh.Normals.Add(new Vector3D(0, -1, 0));

            //oben
            for(int thetaI = 0; thetaI < this.ThetaDiv - 0; thetaI++) {
                //der äußere Rand
                mesh.TriangleIndices.Add(0 + thetaI * factor);
                mesh.TriangleIndices.Add(1 + thetaI * factor);
                mesh.TriangleIndices.Add(14 + thetaI * factor);

                mesh.TriangleIndices.Add(14 + thetaI * factor);
                mesh.TriangleIndices.Add(1 + thetaI * factor);
                mesh.TriangleIndices.Add(15 + thetaI * factor);

                //Die obere Kante
                mesh.TriangleIndices.Add(0 + thetaI * factor);
                mesh.TriangleIndices.Add(14 + thetaI * factor);
                mesh.TriangleIndices.Add(2 + thetaI * factor);

                mesh.TriangleIndices.Add(2 + thetaI * factor);
                mesh.TriangleIndices.Add(14 + thetaI * factor);
                mesh.TriangleIndices.Add(16 + thetaI * factor);

                mesh.TriangleIndices.Add(1 + thetaI * factor);
                mesh.TriangleIndices.Add(3 + thetaI * factor);
                mesh.TriangleIndices.Add(17 + thetaI * factor);

                mesh.TriangleIndices.Add(1 + thetaI * factor);
                mesh.TriangleIndices.Add(17 + thetaI * factor);
                mesh.TriangleIndices.Add(15 + thetaI * factor);

                ////Kante innenseite
                mesh.TriangleIndices.Add(4 + thetaI * factor);
                mesh.TriangleIndices.Add(2 + thetaI * factor);
                mesh.TriangleIndices.Add(16 + thetaI * factor);

                mesh.TriangleIndices.Add(4 + thetaI * factor);
                mesh.TriangleIndices.Add(16 + thetaI * factor);
                mesh.TriangleIndices.Add(18 + thetaI * factor);

                mesh.TriangleIndices.Add(3 + thetaI * factor);
                mesh.TriangleIndices.Add(5 + thetaI * factor);
                mesh.TriangleIndices.Add(19 + thetaI * factor);

                mesh.TriangleIndices.Add(3 + thetaI * factor);
                mesh.TriangleIndices.Add(19 + thetaI * factor);
                mesh.TriangleIndices.Add(17 + thetaI * factor);

                ////Fläche bin zum ersten Hügel
                mesh.TriangleIndices.Add(6 + thetaI * factor);
                mesh.TriangleIndices.Add(4 + thetaI * factor);
                mesh.TriangleIndices.Add(18 + thetaI * factor);

                mesh.TriangleIndices.Add(6 + thetaI * factor);
                mesh.TriangleIndices.Add(18 + thetaI * factor);
                mesh.TriangleIndices.Add(20 + thetaI * factor);

                mesh.TriangleIndices.Add(5 + thetaI * factor);
                mesh.TriangleIndices.Add(7 + thetaI * factor);
                mesh.TriangleIndices.Add(19 + thetaI * factor);

                mesh.TriangleIndices.Add(7 + thetaI * factor);
                mesh.TriangleIndices.Add(21 + thetaI * factor);
                mesh.TriangleIndices.Add(19 + thetaI * factor);

                //Steigung zum ersten Hügel
                mesh.TriangleIndices.Add(6 + thetaI * factor);
                mesh.TriangleIndices.Add(20 + thetaI * factor);
                mesh.TriangleIndices.Add(22 + thetaI * factor);

                mesh.TriangleIndices.Add(6 + thetaI * factor);
                mesh.TriangleIndices.Add(22 + thetaI * factor);
                mesh.TriangleIndices.Add(8 + thetaI * factor);

                mesh.TriangleIndices.Add(7 + thetaI * factor);
                mesh.TriangleIndices.Add(23 + thetaI * factor);
                mesh.TriangleIndices.Add(21 + thetaI * factor);

                mesh.TriangleIndices.Add(7 + thetaI * factor);
                mesh.TriangleIndices.Add(9 + thetaI * factor);
                mesh.TriangleIndices.Add(23 + thetaI * factor);

                // Oberfläche erster Hügel
                mesh.TriangleIndices.Add(8 + thetaI * factor);
                mesh.TriangleIndices.Add(22 + thetaI * factor);
                mesh.TriangleIndices.Add(24 + thetaI * factor);

                mesh.TriangleIndices.Add(8 + thetaI * factor);
                mesh.TriangleIndices.Add(24 + thetaI * factor);
                mesh.TriangleIndices.Add(10 + thetaI * factor);

                mesh.TriangleIndices.Add(9 + thetaI * factor);
                mesh.TriangleIndices.Add(25 + thetaI * factor);
                mesh.TriangleIndices.Add(23 + thetaI * factor);

                mesh.TriangleIndices.Add(9 + thetaI * factor);
                mesh.TriangleIndices.Add(11 + thetaI * factor);
                mesh.TriangleIndices.Add(25 + thetaI * factor);

                // Gefälle vom ersten Hügel

                mesh.TriangleIndices.Add(10 + thetaI * factor);
                mesh.TriangleIndices.Add(24 + thetaI * factor);
                mesh.TriangleIndices.Add(26 + thetaI * factor);

                mesh.TriangleIndices.Add(10 + thetaI * factor);
                mesh.TriangleIndices.Add(26 + thetaI * factor);
                mesh.TriangleIndices.Add(12 + thetaI * factor);

                mesh.TriangleIndices.Add(11 + thetaI * factor);
                mesh.TriangleIndices.Add(27 + thetaI * factor);
                mesh.TriangleIndices.Add(25 + thetaI * factor);

                mesh.TriangleIndices.Add(11 + thetaI * factor);
                mesh.TriangleIndices.Add(13 + thetaI * factor);
                mesh.TriangleIndices.Add(27 + thetaI * factor);

                //Punkte zur Mitte hin verbinden
                //oben
                mesh.TriangleIndices.Add(12 + thetaI * factor);
                mesh.TriangleIndices.Add(26 + thetaI * factor);
                mesh.TriangleIndices.Add(mesh.Positions.Count - 2);

                //unten
                mesh.TriangleIndices.Add(27 + thetaI * factor);
                mesh.TriangleIndices.Add(13 + thetaI * factor);
                mesh.TriangleIndices.Add(mesh.Positions.Count - 1);
            }

            //// Rand schließen
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor - 2);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor - 1);

            mesh.TriangleIndices.Add(mesh.Positions.Count - factor - 1);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);

            ////Die obere Kante schließen
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor - 2);

            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor - 2);

            //untere Kante schließen
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor - 1);

            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor - 1);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 1);

            // weg nach unten Schließen
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor);

            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 2);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor);

            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 1);

            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 1);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 3);

            // Weg bis zum ersten Huckel schließen
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 2);

            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 2);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 4);

            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 3);

            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 3);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 5);

            //Anstieg zum ersten Hügel
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(8);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 4);

            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 4);
            mesh.TriangleIndices.Add(8);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 6);

            mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 5);

            mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 5);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 7);

            // Oberfläche Hügel schließen
            mesh.TriangleIndices.Add(8);
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 6);

            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 6);
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 8);

            mesh.TriangleIndices.Add(11);
            mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 7);

            mesh.TriangleIndices.Add(11);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 7);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 9);

            // Abstieg vom ersten Hügel schließen
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(12);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 8);

            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 8);
            mesh.TriangleIndices.Add(12);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 10);

            mesh.TriangleIndices.Add(13);
            mesh.TriangleIndices.Add(11);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 9);

            mesh.TriangleIndices.Add(13);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 9);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 11);

            // zur Mitte schließen
            mesh.TriangleIndices.Add(factor - 2);
            mesh.TriangleIndices.Add(mesh.Positions.Count - 2);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 10);

            //unten
            mesh.TriangleIndices.Add(factor - 1);
            mesh.TriangleIndices.Add(mesh.Positions.Count - factor + 11);
            mesh.TriangleIndices.Add(mesh.Positions.Count - 1);

            mesh.Freeze();

            return mesh;
        }
    }
}