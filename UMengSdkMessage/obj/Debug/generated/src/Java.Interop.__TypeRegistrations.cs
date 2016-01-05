using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/google/protobuf",
						"org/android/agoo/service",
					},
					new Converter<string, Type>[]{
						lookup_com_google_protobuf_package,
						lookup_org_android_agoo_service_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_google_protobuf_mappings;
		static Type lookup_com_google_protobuf_package (string klass)
		{
			if (package_com_google_protobuf_mappings == null) {
				package_com_google_protobuf_mappings = new string[]{
					"com/google/protobuf/Descriptors$FieldDescriptor$JavaType:Com.Google.Protobuf.Descriptors/JavaType",
					"com/google/protobuf/Descriptors$FieldDescriptor$Type:Com.Google.Protobuf.Descriptors/Type",
				};
			}

			return Lookup (package_com_google_protobuf_mappings, klass);
		}

		static string[] package_org_android_agoo_service_mappings;
		static Type lookup_org_android_agoo_service_package (string klass)
		{
			if (package_org_android_agoo_service_mappings == null) {
				package_org_android_agoo_service_mappings = new string[]{
					"org/android/agoo/service/ElectionReceiverService$Stub:Org.Android.Agoo.Service.ElectionReceiverServiceStub",
					"org/android/agoo/service/IMessageService$Stub:Org.Android.Agoo.Service.MessageServiceStub",
					"org/android/agoo/service/SendMessage$Stub:Org.Android.Agoo.Service.SendMessageStub",
				};
			}

			return Lookup (package_org_android_agoo_service_mappings, klass);
		}
	}
}
