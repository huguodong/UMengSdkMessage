using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistry']"
	[global::Android.Runtime.Register ("com/google/protobuf/ExtensionRegistry", DoNotGenerateAcw=true)]
	public sealed partial class ExtensionRegistry : global::Com.Google.Protobuf.ExtensionRegistryLite {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistry.ExtensionInfo']"
		[global::Android.Runtime.Register ("com/google/protobuf/ExtensionRegistry$ExtensionInfo", DoNotGenerateAcw=true)]
		public sealed partial class ExtensionInfo : global::Java.Lang.Object {

			internal ExtensionInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/ExtensionRegistry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExtensionRegistry); }
		}

		internal ExtensionRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getEmptyRegistry;
		public static global::Com.Google.Protobuf.ExtensionRegistry EmptyRegistry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistry']/method[@name='getEmptyRegistry' and count(parameter)=0]"
			[Register ("getEmptyRegistry", "()Lcom/google/protobuf/ExtensionRegistry;", "GetGetEmptyRegistryHandler")]
			get {
				if (id_getEmptyRegistry == IntPtr.Zero)
					id_getEmptyRegistry = JNIEnv.GetStaticMethodID (class_ref, "getEmptyRegistry", "()Lcom/google/protobuf/ExtensionRegistry;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistry> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEmptyRegistry), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_findExtensionByName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistry']/method[@name='findExtensionByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findExtensionByName", "(Ljava/lang/String;)Lcom/google/protobuf/ExtensionRegistry$ExtensionInfo;", "")]
		public global::Com.Google.Protobuf.ExtensionRegistry.ExtensionInfo FindExtensionByName (string p0)
		{
			if (id_findExtensionByName_Ljava_lang_String_ == IntPtr.Zero)
				id_findExtensionByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findExtensionByName", "(Ljava/lang/String;)Lcom/google/protobuf/ExtensionRegistry$ExtensionInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Google.Protobuf.ExtensionRegistry.ExtensionInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistry.ExtensionInfo> (JNIEnv.CallObjectMethod  (Handle, id_findExtensionByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_findExtensionByNumber_Lcom_google_protobuf_Descriptors_Descriptor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistry']/method[@name='findExtensionByNumber' and count(parameter)=2 and parameter[1][@type='com.google.protobuf.Descriptors.Descriptor'] and parameter[2][@type='int']]"
		[Register ("findExtensionByNumber", "(Lcom/google/protobuf/Descriptors$Descriptor;I)Lcom/google/protobuf/ExtensionRegistry$ExtensionInfo;", "")]
		public global::Com.Google.Protobuf.ExtensionRegistry.ExtensionInfo FindExtensionByNumber (global::Com.Google.Protobuf.Descriptors.Descriptor p0, int p1)
		{
			if (id_findExtensionByNumber_Lcom_google_protobuf_Descriptors_Descriptor_I == IntPtr.Zero)
				id_findExtensionByNumber_Lcom_google_protobuf_Descriptors_Descriptor_I = JNIEnv.GetMethodID (class_ref, "findExtensionByNumber", "(Lcom/google/protobuf/Descriptors$Descriptor;I)Lcom/google/protobuf/ExtensionRegistry$ExtensionInfo;");
			global::Com.Google.Protobuf.ExtensionRegistry.ExtensionInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistry.ExtensionInfo> (JNIEnv.CallObjectMethod  (Handle, id_findExtensionByNumber_Lcom_google_protobuf_Descriptors_Descriptor_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistry']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/google/protobuf/ExtensionRegistry;", "")]
		public static global::Com.Google.Protobuf.ExtensionRegistry NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/google/protobuf/ExtensionRegistry;");
			return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistry> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
		}

	}
}
