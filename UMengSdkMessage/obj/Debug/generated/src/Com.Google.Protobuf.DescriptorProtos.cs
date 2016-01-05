using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='DescriptorProtos']"
	[global::Android.Runtime.Register ("com/google/protobuf/DescriptorProtos", DoNotGenerateAcw=true)]
	public sealed partial class DescriptorProtos : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/DescriptorProtos", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DescriptorProtos); }
		}

		internal DescriptorProtos (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDescriptor;
		public static global::Com.Google.Protobuf.Descriptors.FileDescriptor Descriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='DescriptorProtos']/method[@name='getDescriptor' and count(parameter)=0]"
			[Register ("getDescriptor", "()Lcom/google/protobuf/Descriptors$FileDescriptor;", "GetGetDescriptorHandler")]
			get {
				if (id_getDescriptor == IntPtr.Zero)
					id_getDescriptor = JNIEnv.GetStaticMethodID (class_ref, "getDescriptor", "()Lcom/google/protobuf/Descriptors$FileDescriptor;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.FileDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDescriptor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_registerAllExtensions_Lcom_google_protobuf_ExtensionRegistry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='DescriptorProtos']/method[@name='registerAllExtensions' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.ExtensionRegistry']]"
		[Register ("registerAllExtensions", "(Lcom/google/protobuf/ExtensionRegistry;)V", "")]
		public static void RegisterAllExtensions (global::Com.Google.Protobuf.ExtensionRegistry p0)
		{
			if (id_registerAllExtensions_Lcom_google_protobuf_ExtensionRegistry_ == IntPtr.Zero)
				id_registerAllExtensions_Lcom_google_protobuf_ExtensionRegistry_ = JNIEnv.GetStaticMethodID (class_ref, "registerAllExtensions", "(Lcom/google/protobuf/ExtensionRegistry;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_registerAllExtensions_Lcom_google_protobuf_ExtensionRegistry_, new JValue (p0));
		}

	}
}
