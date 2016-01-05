using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']"
	[global::Android.Runtime.Register ("com/google/protobuf/UnknownFieldSet", DoNotGenerateAcw=true)]
	public sealed partial class UnknownFieldSet : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']"
		[global::Android.Runtime.Register ("com/google/protobuf/UnknownFieldSet$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/UnknownFieldSet$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDefaultInstanceForType;
			public global::Com.Google.Protobuf.UnknownFieldSet DefaultInstanceForType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='getDefaultInstanceForType' and count(parameter)=0]"
				[Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/UnknownFieldSet;", "GetGetDefaultInstanceForTypeHandler")]
				get {
					if (id_getDefaultInstanceForType == IntPtr.Zero)
						id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/google/protobuf/UnknownFieldSet;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_isInitialized;
			public bool IsInitialized {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='isInitialized' and count(parameter)=0]"
				[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
				get {
					if (id_isInitialized == IntPtr.Zero)
						id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_isInitialized);
				}
			}

			static IntPtr id_addField_ILcom_google_protobuf_UnknownFieldSet_Field_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='addField' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.protobuf.UnknownFieldSet.Field']]"
			[Register ("addField", "(ILcom/google/protobuf/UnknownFieldSet$Field;)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder AddField (int p0, global::Com.Google.Protobuf.UnknownFieldSet.Field p1)
			{
				if (id_addField_ILcom_google_protobuf_UnknownFieldSet_Field_ == IntPtr.Zero)
					id_addField_ILcom_google_protobuf_UnknownFieldSet_Field_ = JNIEnv.GetMethodID (class_ref, "addField", "(ILcom/google/protobuf/UnknownFieldSet$Field;)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addField_ILcom_google_protobuf_UnknownFieldSet_Field_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_asMap;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='asMap' and count(parameter)=0]"
			[Register ("asMap", "()Ljava/util/Map;", "")]
			public global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Com.Google.Protobuf.UnknownFieldSet.Field> AsMap ()
			{
				if (id_asMap == IntPtr.Zero)
					id_asMap = JNIEnv.GetMethodID (class_ref, "asMap", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Com.Google.Protobuf.UnknownFieldSet.Field>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_asMap), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/google/protobuf/UnknownFieldSet;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/protobuf/UnknownFieldSet;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_buildPartial;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='buildPartial' and count(parameter)=0]"
			[Register ("buildPartial", "()Lcom/google/protobuf/UnknownFieldSet;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet BuildPartial ()
			{
				if (id_buildPartial == IntPtr.Zero)
					id_buildPartial = JNIEnv.GetMethodID (class_ref, "buildPartial", "()Lcom/google/protobuf/UnknownFieldSet;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet> (JNIEnv.CallObjectMethod  (Handle, id_buildPartial), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_clear;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/google/protobuf/UnknownFieldSet$Builder;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_clone;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='clone' and count(parameter)=0]"
			[Register ("clone", "()Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder Clone ()
			{
				if (id_clone == IntPtr.Zero)
					id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/google/protobuf/UnknownFieldSet$Builder;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_hasField_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='hasField' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("hasField", "(I)Z", "")]
			public bool HasField (int p0)
			{
				if (id_hasField_I == IntPtr.Zero)
					id_hasField_I = JNIEnv.GetMethodID (class_ref, "hasField", "(I)Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_hasField_I, new JValue (p0));
			}

			static IntPtr id_mergeDelimitedFrom_Ljava_io_InputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeDelimitedFrom' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("mergeDelimitedFrom", "(Ljava/io/InputStream;)Z", "")]
			public bool MergeDelimitedFrom (global::System.IO.Stream p0)
			{
				if (id_mergeDelimitedFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_mergeDelimitedFrom_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "mergeDelimitedFrom", "(Ljava/io/InputStream;)Z");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_mergeDelimitedFrom_Ljava_io_InputStream_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeDelimitedFrom' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='com.google.protobuf.ExtensionRegistryLite']]"
			[Register ("mergeDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Z", "")]
			public bool MergeDelimitedFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeDelimitedFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Z");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_mergeDelimitedFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_mergeField_ILcom_google_protobuf_UnknownFieldSet_Field_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeField' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.protobuf.UnknownFieldSet.Field']]"
			[Register ("mergeField", "(ILcom/google/protobuf/UnknownFieldSet$Field;)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeField (int p0, global::Com.Google.Protobuf.UnknownFieldSet.Field p1)
			{
				if (id_mergeField_ILcom_google_protobuf_UnknownFieldSet_Field_ == IntPtr.Zero)
					id_mergeField_ILcom_google_protobuf_UnknownFieldSet_Field_ = JNIEnv.GetMethodID (class_ref, "mergeField", "(ILcom/google/protobuf/UnknownFieldSet$Field;)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeField_ILcom_google_protobuf_UnknownFieldSet_Field_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_mergeFieldFrom_ILcom_google_protobuf_CodedInputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeFieldFrom' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.protobuf.CodedInputStream']]"
			[Register ("mergeFieldFrom", "(ILcom/google/protobuf/CodedInputStream;)Z", "")]
			public bool MergeFieldFrom (int p0, global::Com.Google.Protobuf.CodedInputStream p1)
			{
				if (id_mergeFieldFrom_ILcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_mergeFieldFrom_ILcom_google_protobuf_CodedInputStream_ = JNIEnv.GetMethodID (class_ref, "mergeFieldFrom", "(ILcom/google/protobuf/CodedInputStream;)Z");
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_mergeFieldFrom_ILcom_google_protobuf_CodedInputStream_, new JValue (p0), new JValue (p1));
				return __ret;
			}

			static IntPtr id_mergeFrom_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeFrom' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("mergeFrom", "([B)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeFrom (byte[] p0)
			{
				if (id_mergeFrom_arrayB == IntPtr.Zero)
					id_mergeFrom_arrayB = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([B)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeFrom' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.google.protobuf.ExtensionRegistryLite']]"
			[Register ("mergeFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeFrom (byte[] p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([BLcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_arrayBLcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_mergeFrom_arrayBII;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeFrom' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("mergeFrom", "([BII)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeFrom (byte[] p0, int p1, int p2)
			{
				if (id_mergeFrom_arrayBII == IntPtr.Zero)
					id_mergeFrom_arrayBII = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([BII)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeFrom' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.google.protobuf.ExtensionRegistryLite']]"
			[Register ("mergeFrom", "([BIILcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeFrom (byte[] p0, int p1, int p2, global::Com.Google.Protobuf.ExtensionRegistryLite p3)
			{
				if (id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "([BIILcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_arrayBIILcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeFrom' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.CodedInputStream']]"
			[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0)
			{
				if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
					id_mergeFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeFrom' and count(parameter)=2 and parameter[1][@type='com.google.protobuf.CodedInputStream'] and parameter[2][@type='com.google.protobuf.ExtensionRegistryLite']]"
			[Register ("mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeFrom (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_mergeFrom_Lcom_google_protobuf_UnknownFieldSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeFrom' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.UnknownFieldSet']]"
			[Register ("mergeFrom", "(Lcom/google/protobuf/UnknownFieldSet;)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeFrom (global::Com.Google.Protobuf.UnknownFieldSet p0)
			{
				if (id_mergeFrom_Lcom_google_protobuf_UnknownFieldSet_ == IntPtr.Zero)
					id_mergeFrom_Lcom_google_protobuf_UnknownFieldSet_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/UnknownFieldSet;)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_UnknownFieldSet_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_mergeFrom_Ljava_io_InputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeFrom' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("mergeFrom", "(Ljava/io/InputStream;)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeFrom (global::System.IO.Stream p0)
			{
				if (id_mergeFrom_Ljava_io_InputStream_ == IntPtr.Zero)
					id_mergeFrom_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Ljava/io/InputStream;)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeFrom' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='com.google.protobuf.ExtensionRegistryLite']]"
			[Register ("mergeFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeFrom (global::System.IO.Stream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1)
			{
				if (id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ == IntPtr.Zero)
					id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Ljava/io/InputStream;Lcom/google/protobuf/ExtensionRegistryLite;)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Ljava_io_InputStream_Lcom_google_protobuf_ExtensionRegistryLite_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_mergeVarintField_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Builder']/method[@name='mergeVarintField' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("mergeVarintField", "(II)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
			public global::Com.Google.Protobuf.UnknownFieldSet.Builder MergeVarintField (int p0, int p1)
			{
				if (id_mergeVarintField_II == IntPtr.Zero)
					id_mergeVarintField_II = JNIEnv.GetMethodID (class_ref, "mergeVarintField", "(II)Lcom/google/protobuf/UnknownFieldSet$Builder;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeVarintField_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']"
		[global::Android.Runtime.Register ("com/google/protobuf/UnknownFieldSet$Field", DoNotGenerateAcw=true)]
		public sealed partial class Field : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field.Builder']"
			[global::Android.Runtime.Register ("com/google/protobuf/UnknownFieldSet$Field$Builder", DoNotGenerateAcw=true)]
			public sealed partial class Builder : global::Java.Lang.Object {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/google/protobuf/UnknownFieldSet$Field$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_addFixed32_I;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field.Builder']/method[@name='addFixed32' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("addFixed32", "(I)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;", "")]
				public global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder AddFixed32 (int p0)
				{
					if (id_addFixed32_I == IntPtr.Zero)
						id_addFixed32_I = JNIEnv.GetMethodID (class_ref, "addFixed32", "(I)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addFixed32_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_addFixed64_J;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field.Builder']/method[@name='addFixed64' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("addFixed64", "(J)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;", "")]
				public global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder AddFixed64 (long p0)
				{
					if (id_addFixed64_J == IntPtr.Zero)
						id_addFixed64_J = JNIEnv.GetMethodID (class_ref, "addFixed64", "(J)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addFixed64_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_addGroup_Lcom_google_protobuf_UnknownFieldSet_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field.Builder']/method[@name='addGroup' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.UnknownFieldSet']]"
				[Register ("addGroup", "(Lcom/google/protobuf/UnknownFieldSet;)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;", "")]
				public global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder AddGroup (global::Com.Google.Protobuf.UnknownFieldSet p0)
				{
					if (id_addGroup_Lcom_google_protobuf_UnknownFieldSet_ == IntPtr.Zero)
						id_addGroup_Lcom_google_protobuf_UnknownFieldSet_ = JNIEnv.GetMethodID (class_ref, "addGroup", "(Lcom/google/protobuf/UnknownFieldSet;)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;");
					global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addGroup_Lcom_google_protobuf_UnknownFieldSet_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static IntPtr id_addVarint_J;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field.Builder']/method[@name='addVarint' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("addVarint", "(J)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;", "")]
				public global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder AddVarint (long p0)
				{
					if (id_addVarint_J == IntPtr.Zero)
						id_addVarint_J = JNIEnv.GetMethodID (class_ref, "addVarint", "(J)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addVarint_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_build;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field.Builder']/method[@name='build' and count(parameter)=0]"
				[Register ("build", "()Lcom/google/protobuf/UnknownFieldSet$Field;", "")]
				public global::Com.Google.Protobuf.UnknownFieldSet.Field Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/protobuf/UnknownFieldSet$Field;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_clear;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field.Builder']/method[@name='clear' and count(parameter)=0]"
				[Register ("clear", "()Lcom/google/protobuf/UnknownFieldSet$Field$Builder;", "")]
				public global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/google/protobuf/UnknownFieldSet$Field$Builder;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_mergeFrom_Lcom_google_protobuf_UnknownFieldSet_Field_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field.Builder']/method[@name='mergeFrom' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.UnknownFieldSet.Field']]"
				[Register ("mergeFrom", "(Lcom/google/protobuf/UnknownFieldSet$Field;)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;", "")]
				public global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder MergeFrom (global::Com.Google.Protobuf.UnknownFieldSet.Field p0)
				{
					if (id_mergeFrom_Lcom_google_protobuf_UnknownFieldSet_Field_ == IntPtr.Zero)
						id_mergeFrom_Lcom_google_protobuf_UnknownFieldSet_Field_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/UnknownFieldSet$Field;)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;");
					global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_UnknownFieldSet_Field_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/UnknownFieldSet$Field", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Field); }
			}

			internal Field (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDefaultInstance;
			public static global::Com.Google.Protobuf.UnknownFieldSet.Field DefaultInstance {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='getDefaultInstance' and count(parameter)=0]"
				[Register ("getDefaultInstance", "()Lcom/google/protobuf/UnknownFieldSet$Field;", "GetGetDefaultInstanceHandler")]
				get {
					if (id_getDefaultInstance == IntPtr.Zero)
						id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/google/protobuf/UnknownFieldSet$Field;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getFixed32List;
			public global::System.Collections.Generic.IList<global::Java.Lang.Integer> Fixed32List {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='getFixed32List' and count(parameter)=0]"
				[Register ("getFixed32List", "()Ljava/util/List;", "GetGetFixed32ListHandler")]
				get {
					if (id_getFixed32List == IntPtr.Zero)
						id_getFixed32List = JNIEnv.GetMethodID (class_ref, "getFixed32List", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getFixed32List), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getFixed64List;
			public global::System.Collections.Generic.IList<global::Java.Lang.Long> Fixed64List {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='getFixed64List' and count(parameter)=0]"
				[Register ("getFixed64List", "()Ljava/util/List;", "GetGetFixed64ListHandler")]
				get {
					if (id_getFixed64List == IntPtr.Zero)
						id_getFixed64List = JNIEnv.GetMethodID (class_ref, "getFixed64List", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Java.Lang.Long>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getFixed64List), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getGroupList;
			public global::System.Collections.Generic.IList<global::Com.Google.Protobuf.UnknownFieldSet> GroupList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='getGroupList' and count(parameter)=0]"
				[Register ("getGroupList", "()Ljava/util/List;", "GetGetGroupListHandler")]
				get {
					if (id_getGroupList == IntPtr.Zero)
						id_getGroupList = JNIEnv.GetMethodID (class_ref, "getGroupList", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Google.Protobuf.UnknownFieldSet>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getGroupList), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getVarintList;
			public global::System.Collections.Generic.IList<global::Java.Lang.Long> VarintList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='getVarintList' and count(parameter)=0]"
				[Register ("getVarintList", "()Ljava/util/List;", "GetGetVarintListHandler")]
				get {
					if (id_getVarintList == IntPtr.Zero)
						id_getVarintList = JNIEnv.GetMethodID (class_ref, "getVarintList", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Java.Lang.Long>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getVarintList), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getSerializedSize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='getSerializedSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getSerializedSize", "(I)I", "")]
			public int GetSerializedSize (int p0)
			{
				if (id_getSerializedSize_I == IntPtr.Zero)
					id_getSerializedSize_I = JNIEnv.GetMethodID (class_ref, "getSerializedSize", "(I)I");
				return JNIEnv.CallIntMethod  (Handle, id_getSerializedSize_I, new JValue (p0));
			}

			static IntPtr id_getSerializedSizeAsMessageSetExtension_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='getSerializedSizeAsMessageSetExtension' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getSerializedSizeAsMessageSetExtension", "(I)I", "")]
			public int GetSerializedSizeAsMessageSetExtension (int p0)
			{
				if (id_getSerializedSizeAsMessageSetExtension_I == IntPtr.Zero)
					id_getSerializedSizeAsMessageSetExtension_I = JNIEnv.GetMethodID (class_ref, "getSerializedSizeAsMessageSetExtension", "(I)I");
				return JNIEnv.CallIntMethod  (Handle, id_getSerializedSizeAsMessageSetExtension_I, new JValue (p0));
			}

			static IntPtr id_newBuilder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='newBuilder' and count(parameter)=0]"
			[Register ("newBuilder", "()Lcom/google/protobuf/UnknownFieldSet$Field$Builder;", "")]
			public static global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder NewBuilder ()
			{
				if (id_newBuilder == IntPtr.Zero)
					id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/google/protobuf/UnknownFieldSet$Field$Builder;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newBuilder_Lcom_google_protobuf_UnknownFieldSet_Field_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='newBuilder' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.UnknownFieldSet.Field']]"
			[Register ("newBuilder", "(Lcom/google/protobuf/UnknownFieldSet$Field;)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;", "")]
			public static global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder NewBuilder (global::Com.Google.Protobuf.UnknownFieldSet.Field p0)
			{
				if (id_newBuilder_Lcom_google_protobuf_UnknownFieldSet_Field_ == IntPtr.Zero)
					id_newBuilder_Lcom_google_protobuf_UnknownFieldSet_Field_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/google/protobuf/UnknownFieldSet$Field;)Lcom/google/protobuf/UnknownFieldSet$Field$Builder;");
				global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_google_protobuf_UnknownFieldSet_Field_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_writeAsMessageSetExtensionTo_ILcom_google_protobuf_CodedOutputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='writeAsMessageSetExtensionTo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.protobuf.CodedOutputStream']]"
			[Register ("writeAsMessageSetExtensionTo", "(ILcom/google/protobuf/CodedOutputStream;)V", "")]
			public void WriteAsMessageSetExtensionTo (int p0, global::Com.Google.Protobuf.CodedOutputStream p1)
			{
				if (id_writeAsMessageSetExtensionTo_ILcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
					id_writeAsMessageSetExtensionTo_ILcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeAsMessageSetExtensionTo", "(ILcom/google/protobuf/CodedOutputStream;)V");
				JNIEnv.CallVoidMethod  (Handle, id_writeAsMessageSetExtensionTo_ILcom_google_protobuf_CodedOutputStream_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_writeTo_ILcom_google_protobuf_CodedOutputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet.Field']/method[@name='writeTo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.protobuf.CodedOutputStream']]"
			[Register ("writeTo", "(ILcom/google/protobuf/CodedOutputStream;)V", "")]
			public void WriteTo (int p0, global::Com.Google.Protobuf.CodedOutputStream p1)
			{
				if (id_writeTo_ILcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
					id_writeTo_ILcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(ILcom/google/protobuf/CodedOutputStream;)V");
				JNIEnv.CallVoidMethod  (Handle, id_writeTo_ILcom_google_protobuf_CodedOutputStream_, new JValue (p0), new JValue (p1));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/UnknownFieldSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnknownFieldSet); }
		}

		internal UnknownFieldSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDefaultInstance;
		public static global::Com.Google.Protobuf.UnknownFieldSet DefaultInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='getDefaultInstance' and count(parameter)=0]"
			[Register ("getDefaultInstance", "()Lcom/google/protobuf/UnknownFieldSet;", "GetGetDefaultInstanceHandler")]
			get {
				if (id_getDefaultInstance == IntPtr.Zero)
					id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/google/protobuf/UnknownFieldSet;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDefaultInstanceForType;
		public global::Com.Google.Protobuf.UnknownFieldSet DefaultInstanceForType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='getDefaultInstanceForType' and count(parameter)=0]"
			[Register ("getDefaultInstanceForType", "()Lcom/google/protobuf/UnknownFieldSet;", "GetGetDefaultInstanceForTypeHandler")]
			get {
				if (id_getDefaultInstanceForType == IntPtr.Zero)
					id_getDefaultInstanceForType = JNIEnv.GetMethodID (class_ref, "getDefaultInstanceForType", "()Lcom/google/protobuf/UnknownFieldSet;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultInstanceForType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isInitialized;
		public bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isInitialized);
			}
		}

		static IntPtr id_getSerializedSize;
		public int SerializedSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='getSerializedSize' and count(parameter)=0]"
			[Register ("getSerializedSize", "()I", "GetGetSerializedSizeHandler")]
			get {
				if (id_getSerializedSize == IntPtr.Zero)
					id_getSerializedSize = JNIEnv.GetMethodID (class_ref, "getSerializedSize", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getSerializedSize);
			}
		}

		static IntPtr id_getSerializedSizeAsMessageSet;
		public int SerializedSizeAsMessageSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='getSerializedSizeAsMessageSet' and count(parameter)=0]"
			[Register ("getSerializedSizeAsMessageSet", "()I", "GetGetSerializedSizeAsMessageSetHandler")]
			get {
				if (id_getSerializedSizeAsMessageSet == IntPtr.Zero)
					id_getSerializedSizeAsMessageSet = JNIEnv.GetMethodID (class_ref, "getSerializedSizeAsMessageSet", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getSerializedSizeAsMessageSet);
			}
		}

		static IntPtr id_asMap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='asMap' and count(parameter)=0]"
		[Register ("asMap", "()Ljava/util/Map;", "")]
		public global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Com.Google.Protobuf.UnknownFieldSet.Field> AsMap ()
		{
			if (id_asMap == IntPtr.Zero)
				id_asMap = JNIEnv.GetMethodID (class_ref, "asMap", "()Ljava/util/Map;");
			return global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Com.Google.Protobuf.UnknownFieldSet.Field>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_asMap), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getField_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='getField' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getField", "(I)Lcom/google/protobuf/UnknownFieldSet$Field;", "")]
		public global::Com.Google.Protobuf.UnknownFieldSet.Field GetField (int p0)
		{
			if (id_getField_I == IntPtr.Zero)
				id_getField_I = JNIEnv.GetMethodID (class_ref, "getField", "(I)Lcom/google/protobuf/UnknownFieldSet$Field;");
			return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Field> (JNIEnv.CallObjectMethod  (Handle, id_getField_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_hasField_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='hasField' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasField", "(I)Z", "")]
		public bool HasField (int p0)
		{
			if (id_hasField_I == IntPtr.Zero)
				id_hasField_I = JNIEnv.GetMethodID (class_ref, "hasField", "(I)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_hasField_I, new JValue (p0));
		}

		static IntPtr id_newBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
		public static global::Com.Google.Protobuf.UnknownFieldSet.Builder NewBuilder ()
		{
			if (id_newBuilder == IntPtr.Zero)
				id_newBuilder = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "()Lcom/google/protobuf/UnknownFieldSet$Builder;");
			return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_newBuilder_Lcom_google_protobuf_UnknownFieldSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='newBuilder' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.UnknownFieldSet']]"
		[Register ("newBuilder", "(Lcom/google/protobuf/UnknownFieldSet;)Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
		public static global::Com.Google.Protobuf.UnknownFieldSet.Builder NewBuilder (global::Com.Google.Protobuf.UnknownFieldSet p0)
		{
			if (id_newBuilder_Lcom_google_protobuf_UnknownFieldSet_ == IntPtr.Zero)
				id_newBuilder_Lcom_google_protobuf_UnknownFieldSet_ = JNIEnv.GetStaticMethodID (class_ref, "newBuilder", "(Lcom/google/protobuf/UnknownFieldSet;)Lcom/google/protobuf/UnknownFieldSet$Builder;");
			global::Com.Google.Protobuf.UnknownFieldSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBuilder_Lcom_google_protobuf_UnknownFieldSet_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newBuilderForType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='newBuilderForType' and count(parameter)=0]"
		[Register ("newBuilderForType", "()Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
		public global::Com.Google.Protobuf.UnknownFieldSet.Builder NewBuilderForType ()
		{
			if (id_newBuilderForType == IntPtr.Zero)
				id_newBuilderForType = JNIEnv.GetMethodID (class_ref, "newBuilderForType", "()Lcom/google/protobuf/UnknownFieldSet$Builder;");
			return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_newBuilderForType), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_parseFrom_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='parseFrom' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseFrom", "([B)Lcom/google/protobuf/UnknownFieldSet;", "")]
		public static global::Com.Google.Protobuf.UnknownFieldSet ParseFrom (byte[] p0)
		{
			if (id_parseFrom_arrayB == IntPtr.Zero)
				id_parseFrom_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "([B)Lcom/google/protobuf/UnknownFieldSet;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.UnknownFieldSet __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_parseFrom_Lcom_google_protobuf_CodedInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='parseFrom' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.CodedInputStream']]"
		[Register ("parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/google/protobuf/UnknownFieldSet;", "")]
		public static global::Com.Google.Protobuf.UnknownFieldSet ParseFrom (global::Com.Google.Protobuf.CodedInputStream p0)
		{
			if (id_parseFrom_Lcom_google_protobuf_CodedInputStream_ == IntPtr.Zero)
				id_parseFrom_Lcom_google_protobuf_CodedInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Lcom/google/protobuf/CodedInputStream;)Lcom/google/protobuf/UnknownFieldSet;");
			global::Com.Google.Protobuf.UnknownFieldSet __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Lcom_google_protobuf_CodedInputStream_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_parseFrom_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='parseFrom' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("parseFrom", "(Ljava/io/InputStream;)Lcom/google/protobuf/UnknownFieldSet;", "")]
		public static global::Com.Google.Protobuf.UnknownFieldSet ParseFrom (global::System.IO.Stream p0)
		{
			if (id_parseFrom_Ljava_io_InputStream_ == IntPtr.Zero)
				id_parseFrom_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "parseFrom", "(Ljava/io/InputStream;)Lcom/google/protobuf/UnknownFieldSet;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			global::Com.Google.Protobuf.UnknownFieldSet __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFrom_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_toBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='toBuilder' and count(parameter)=0]"
		[Register ("toBuilder", "()Lcom/google/protobuf/UnknownFieldSet$Builder;", "")]
		public global::Com.Google.Protobuf.UnknownFieldSet.Builder ToBuilder ()
		{
			if (id_toBuilder == IntPtr.Zero)
				id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/google/protobuf/UnknownFieldSet$Builder;");
			return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.UnknownFieldSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_toByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "")]
		public byte[] ToByteArray ()
		{
			if (id_toByteArray == IntPtr.Zero)
				id_toByteArray = JNIEnv.GetMethodID (class_ref, "toByteArray", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_writeAsMessageSetTo_Lcom_google_protobuf_CodedOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='writeAsMessageSetTo' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.CodedOutputStream']]"
		[Register ("writeAsMessageSetTo", "(Lcom/google/protobuf/CodedOutputStream;)V", "")]
		public void WriteAsMessageSetTo (global::Com.Google.Protobuf.CodedOutputStream p0)
		{
			if (id_writeAsMessageSetTo_Lcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
				id_writeAsMessageSetTo_Lcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeAsMessageSetTo", "(Lcom/google/protobuf/CodedOutputStream;)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeAsMessageSetTo_Lcom_google_protobuf_CodedOutputStream_, new JValue (p0));
		}

		static IntPtr id_writeDelimitedTo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='writeDelimitedTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeDelimitedTo", "(Ljava/io/OutputStream;)V", "")]
		public void WriteDelimitedTo (global::System.IO.Stream p0)
		{
			if (id_writeDelimitedTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeDelimitedTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeDelimitedTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_writeDelimitedTo_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_writeTo_Lcom_google_protobuf_CodedOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.CodedOutputStream']]"
		[Register ("writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V", "")]
		public void WriteTo (global::Com.Google.Protobuf.CodedOutputStream p0)
		{
			if (id_writeTo_Lcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
				id_writeTo_Lcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Lcom/google/protobuf/CodedOutputStream;)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeTo_Lcom_google_protobuf_CodedOutputStream_, new JValue (p0));
		}

		static IntPtr id_writeTo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='UnknownFieldSet']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "")]
		public void WriteTo (global::System.IO.Stream p0)
		{
			if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_writeTo_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
