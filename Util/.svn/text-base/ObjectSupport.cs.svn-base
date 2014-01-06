using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Util {
    public static class ObjectSupport {

        public static T Copy<T>(T objectToCopy) {
            BinaryFormatter formatter = new BinaryFormatter();
            using(MemoryStream mStream = new MemoryStream()) {
                formatter.Serialize(mStream, objectToCopy);
                mStream.Position = 0;
                return (T)formatter.Deserialize(mStream);
            }
        }
    }
}
