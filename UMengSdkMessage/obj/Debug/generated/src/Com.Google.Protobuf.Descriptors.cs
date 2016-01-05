using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors']"
	[global::Android.Runtime.Register ("com/google/protobuf/Descriptors", DoNotGenerateAcw=true)]
	public sealed partial class Descriptors : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']"
		[global::Android.Runtime.Register ("com/google/protobuf/Descriptors$Descriptor", DoNotGenerateAcw=true)]
		public sealed partial class Descriptor : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/Descriptors$Descriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Descriptor); }
			}

			internal Descriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getContainingType;
			public global::Com.Google.Protobuf.Descriptors.Descriptor ContainingType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']/method[@name='getContainingType' and count(parameter)=0]"
				[Register ("getContainingType", "()Lcom/google/protobuf/Descriptors$Descriptor;", "GetGetContainingTypeHandler")]
				get {
					if (id_getContainingType == IntPtr.Zero)
						id_getContainingType = JNIEnv.GetMethodID (class_ref, "getContainingType", "()Lcom/google/protobuf/Descriptors$Descriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Descriptor> (JNIEnv.CallObjectMethod  (Handle, id_getContainingType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getEnumTypes;
			public global::System.Collections.Generic.IList<global::Com.Google.Protobuf.Descriptors.EnumDescriptor> EnumTypes {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']/method[@name='getEnumTypes' and count(parameter)=0]"
				[Register ("getEnumTypes", "()Ljava/util/List;", "GetGetEnumTypesHandler")]
				get {
					if (id_getEnumTypes == IntPtr.Zero)
						id_getEnumTypes = JNIEnv.GetMethodID (class_ref, "getEnumTypes", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Google.Protobuf.Descriptors.EnumDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getEnumTypes), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getFile;
			public global::Com.Google.Protobuf.Descriptors.FileDescriptor File {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']/method[@name='getFile' and count(parameter)=0]"
				[Register ("getFile", "()Lcom/google/protobuf/Descriptors$FileDescriptor;", "GetGetFileHandler")]
				get {
					if (id_getFile == IntPtr.Zero)
						id_getFile = JNIEnv.GetMethodID (class_ref, "getFile", "()Lcom/google/protobuf/Descriptors$FileDescriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.FileDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getFile), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getFullName;
			public string FullName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']/method[@name='getFullName' and count(parameter)=0]"
				[Register ("getFullName", "()Ljava/lang/String;", "GetGetFullNameHandler")]
				get {
					if (id_getFullName == IntPtr.Zero)
						id_getFullName = JNIEnv.GetMethodID (class_ref, "getFullName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFullName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getIndex;
			public int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					if (id_getIndex == IntPtr.Zero)
						id_getIndex = JNIEnv.GetMethodID (class_ref, "getIndex", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getIndex);
				}
			}

			static IntPtr id_getName;
			public string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getNestedTypes;
			public global::System.Collections.Generic.IList<global::Com.Google.Protobuf.Descriptors.Descriptor> NestedTypes {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']/method[@name='getNestedTypes' and count(parameter)=0]"
				[Register ("getNestedTypes", "()Ljava/util/List;", "GetGetNestedTypesHandler")]
				get {
					if (id_getNestedTypes == IntPtr.Zero)
						id_getNestedTypes = JNIEnv.GetMethodID (class_ref, "getNestedTypes", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Google.Protobuf.Descriptors.Descriptor>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getNestedTypes), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_findEnumTypeByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']/method[@name='findEnumTypeByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findEnumTypeByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$EnumDescriptor;", "")]
			public global::Com.Google.Protobuf.Descriptors.EnumDescriptor FindEnumTypeByName (string p0)
			{
				if (id_findEnumTypeByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findEnumTypeByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findEnumTypeByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$EnumDescriptor;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.Descriptors.EnumDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.EnumDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_findEnumTypeByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_findNestedTypeByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']/method[@name='findNestedTypeByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findNestedTypeByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$Descriptor;", "")]
			public global::Com.Google.Protobuf.Descriptors.Descriptor FindNestedTypeByName (string p0)
			{
				if (id_findNestedTypeByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findNestedTypeByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findNestedTypeByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$Descriptor;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.Descriptors.Descriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Descriptor> (JNIEnv.CallObjectMethod  (Handle, id_findNestedTypeByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_isExtensionNumber_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.Descriptor']/method[@name='isExtensionNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("isExtensionNumber", "(I)Z", "")]
			public bool IsExtensionNumber (int p0)
			{
				if (id_isExtensionNumber_I == IntPtr.Zero)
					id_isExtensionNumber_I = JNIEnv.GetMethodID (class_ref, "isExtensionNumber", "(I)Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isExtensionNumber_I, new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.DescriptorValidationException']"
		[global::Android.Runtime.Register ("com/google/protobuf/Descriptors$DescriptorValidationException", DoNotGenerateAcw=true)]
		public partial class DescriptorValidationException : global::Java.Lang.Exception {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/Descriptors$DescriptorValidationException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DescriptorValidationException); }
			}

			protected DescriptorValidationException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getDescription;
#pragma warning disable 0169
			static Delegate GetGetDescriptionHandler ()
			{
				if (cb_getDescription == null)
					cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
				return cb_getDescription;
			}

			static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.Descriptors.DescriptorValidationException __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.DescriptorValidationException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Description);
			}
#pragma warning restore 0169

			static IntPtr id_getDescription;
			public virtual string Description {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.DescriptorValidationException']/method[@name='getDescription' and count(parameter)=0]"
				[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
				get {
					if (id_getDescription == IntPtr.Zero)
						id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getProblemSymbolName;
#pragma warning disable 0169
			static Delegate GetGetProblemSymbolNameHandler ()
			{
				if (cb_getProblemSymbolName == null)
					cb_getProblemSymbolName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProblemSymbolName);
				return cb_getProblemSymbolName;
			}

			static IntPtr n_GetProblemSymbolName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.Descriptors.DescriptorValidationException __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.DescriptorValidationException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ProblemSymbolName);
			}
#pragma warning restore 0169

			static IntPtr id_getProblemSymbolName;
			public virtual string ProblemSymbolName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.DescriptorValidationException']/method[@name='getProblemSymbolName' and count(parameter)=0]"
				[Register ("getProblemSymbolName", "()Ljava/lang/String;", "GetGetProblemSymbolNameHandler")]
				get {
					if (id_getProblemSymbolName == IntPtr.Zero)
						id_getProblemSymbolName = JNIEnv.GetMethodID (class_ref, "getProblemSymbolName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProblemSymbolName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProblemSymbolName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumDescriptor']"
		[global::Android.Runtime.Register ("com/google/protobuf/Descriptors$EnumDescriptor", DoNotGenerateAcw=true)]
		public sealed partial class EnumDescriptor : global::Java.Lang.Object, global::Com.Google.Protobuf.Internal.IEnumLiteMap {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/Descriptors$EnumDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EnumDescriptor); }
			}

			internal EnumDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getContainingType;
			public global::Com.Google.Protobuf.Descriptors.Descriptor ContainingType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumDescriptor']/method[@name='getContainingType' and count(parameter)=0]"
				[Register ("getContainingType", "()Lcom/google/protobuf/Descriptors$Descriptor;", "GetGetContainingTypeHandler")]
				get {
					if (id_getContainingType == IntPtr.Zero)
						id_getContainingType = JNIEnv.GetMethodID (class_ref, "getContainingType", "()Lcom/google/protobuf/Descriptors$Descriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Descriptor> (JNIEnv.CallObjectMethod  (Handle, id_getContainingType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getFile;
			public global::Com.Google.Protobuf.Descriptors.FileDescriptor File {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumDescriptor']/method[@name='getFile' and count(parameter)=0]"
				[Register ("getFile", "()Lcom/google/protobuf/Descriptors$FileDescriptor;", "GetGetFileHandler")]
				get {
					if (id_getFile == IntPtr.Zero)
						id_getFile = JNIEnv.GetMethodID (class_ref, "getFile", "()Lcom/google/protobuf/Descriptors$FileDescriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.FileDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getFile), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getFullName;
			public string FullName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumDescriptor']/method[@name='getFullName' and count(parameter)=0]"
				[Register ("getFullName", "()Ljava/lang/String;", "GetGetFullNameHandler")]
				get {
					if (id_getFullName == IntPtr.Zero)
						id_getFullName = JNIEnv.GetMethodID (class_ref, "getFullName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFullName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getIndex;
			public int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumDescriptor']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					if (id_getIndex == IntPtr.Zero)
						id_getIndex = JNIEnv.GetMethodID (class_ref, "getIndex", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getIndex);
				}
			}

			static IntPtr id_getName;
			public string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumDescriptor']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getValues;
			public global::System.Collections.Generic.IList<global::Com.Google.Protobuf.Descriptors.EnumValueDescriptor> Values {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumDescriptor']/method[@name='getValues' and count(parameter)=0]"
				[Register ("getValues", "()Ljava/util/List;", "GetGetValuesHandler")]
				get {
					if (id_getValues == IntPtr.Zero)
						id_getValues = JNIEnv.GetMethodID (class_ref, "getValues", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Google.Protobuf.Descriptors.EnumValueDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getValues), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_findValueByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumDescriptor']/method[@name='findValueByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findValueByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$EnumValueDescriptor;", "")]
			public global::Com.Google.Protobuf.Descriptors.EnumValueDescriptor FindValueByName (string p0)
			{
				if (id_findValueByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findValueByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findValueByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$EnumValueDescriptor;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.Descriptors.EnumValueDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.EnumValueDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_findValueByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_findValueByNumber_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumDescriptor']/method[@name='findValueByNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findValueByNumber", "(I)Lcom/google/protobuf/Descriptors$EnumValueDescriptor;", "")]
			public global::Com.Google.Protobuf.Descriptors.EnumValueDescriptor FindValueByNumber (int p0)
			{
				if (id_findValueByNumber_I == IntPtr.Zero)
					id_findValueByNumber_I = JNIEnv.GetMethodID (class_ref, "findValueByNumber", "(I)Lcom/google/protobuf/Descriptors$EnumValueDescriptor;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.EnumValueDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_findValueByNumber_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			// This method is explicitly implemented as a member of an instantiated Com.Google.Protobuf.Internal.IEnumLiteMap
			global::Java.Lang.Object global::Com.Google.Protobuf.Internal.IEnumLiteMap.FindValueByNumber (int p0)
			{
				return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(FindValueByNumber (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumValueDescriptor']"
		[global::Android.Runtime.Register ("com/google/protobuf/Descriptors$EnumValueDescriptor", DoNotGenerateAcw=true)]
		public sealed partial class EnumValueDescriptor : global::Java.Lang.Object, global::Com.Google.Protobuf.Internal.IEnumLite {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/Descriptors$EnumValueDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EnumValueDescriptor); }
			}

			internal EnumValueDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getFile;
			public global::Com.Google.Protobuf.Descriptors.FileDescriptor File {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumValueDescriptor']/method[@name='getFile' and count(parameter)=0]"
				[Register ("getFile", "()Lcom/google/protobuf/Descriptors$FileDescriptor;", "GetGetFileHandler")]
				get {
					if (id_getFile == IntPtr.Zero)
						id_getFile = JNIEnv.GetMethodID (class_ref, "getFile", "()Lcom/google/protobuf/Descriptors$FileDescriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.FileDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getFile), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getFullName;
			public string FullName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumValueDescriptor']/method[@name='getFullName' and count(parameter)=0]"
				[Register ("getFullName", "()Ljava/lang/String;", "GetGetFullNameHandler")]
				get {
					if (id_getFullName == IntPtr.Zero)
						id_getFullName = JNIEnv.GetMethodID (class_ref, "getFullName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFullName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getIndex;
			public int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumValueDescriptor']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					if (id_getIndex == IntPtr.Zero)
						id_getIndex = JNIEnv.GetMethodID (class_ref, "getIndex", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getIndex);
				}
			}

			static IntPtr id_getName;
			public string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumValueDescriptor']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getNumber;
			public int Number {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumValueDescriptor']/method[@name='getNumber' and count(parameter)=0]"
				[Register ("getNumber", "()I", "GetGetNumberHandler")]
				get {
					if (id_getNumber == IntPtr.Zero)
						id_getNumber = JNIEnv.GetMethodID (class_ref, "getNumber", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getNumber);
				}
			}

			static IntPtr id_getType;
			public global::Com.Google.Protobuf.Descriptors.EnumDescriptor Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.EnumValueDescriptor']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/google/protobuf/Descriptors$EnumDescriptor;", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/google/protobuf/Descriptors$EnumDescriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.EnumDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']"
		[global::Android.Runtime.Register ("com/google/protobuf/Descriptors$FieldDescriptor$JavaType", DoNotGenerateAcw=true)]
		public sealed partial class JavaType : global::Java.Lang.Enum {


			static IntPtr BOOLEAN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/field[@name='BOOLEAN']"
			[Register ("BOOLEAN")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType Boolean {
				get {
					if (BOOLEAN_jfieldId == IntPtr.Zero)
						BOOLEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOLEAN", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOLEAN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BOOLEAN_jfieldId == IntPtr.Zero)
						BOOLEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOLEAN", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BOOLEAN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BYTE_STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/field[@name='BYTE_STRING']"
			[Register ("BYTE_STRING")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType ByteString {
				get {
					if (BYTE_STRING_jfieldId == IntPtr.Zero)
						BYTE_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE_STRING", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BYTE_STRING_jfieldId == IntPtr.Zero)
						BYTE_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE_STRING", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BYTE_STRING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DOUBLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/field[@name='DOUBLE']"
			[Register ("DOUBLE")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType Double {
				get {
					if (DOUBLE_jfieldId == IntPtr.Zero)
						DOUBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOUBLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DOUBLE_jfieldId == IntPtr.Zero)
						DOUBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DOUBLE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ENUM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/field[@name='ENUM']"
			[Register ("ENUM")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType Enum {
				get {
					if (ENUM_jfieldId == IntPtr.Zero)
						ENUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENUM", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENUM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ENUM_jfieldId == IntPtr.Zero)
						ENUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENUM", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ENUM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FLOAT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/field[@name='FLOAT']"
			[Register ("FLOAT")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType Float {
				get {
					if (FLOAT_jfieldId == IntPtr.Zero)
						FLOAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOAT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FLOAT_jfieldId == IntPtr.Zero)
						FLOAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FLOAT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/field[@name='INT']"
			[Register ("INT")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType Int {
				get {
					if (INT_jfieldId == IntPtr.Zero)
						INT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INT_jfieldId == IntPtr.Zero)
						INT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LONG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/field[@name='LONG']"
			[Register ("LONG")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType Long {
				get {
					if (LONG_jfieldId == IntPtr.Zero)
						LONG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LONG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LONG_jfieldId == IntPtr.Zero)
						LONG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LONG_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/field[@name='MESSAGE']"
			[Register ("MESSAGE")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType Message {
				get {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MESSAGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/field[@name='STRING']"
			[Register ("STRING")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType String {
				get {
					if (STRING_jfieldId == IntPtr.Zero)
						STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STRING_jfieldId == IntPtr.Zero)
						STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STRING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/Descriptors$FieldDescriptor$JavaType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JavaType); }
			}

			internal JavaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;", "")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.Descriptors.JavaType __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.JavaType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;", "")]
			public static global::Com.Google.Protobuf.Descriptors.JavaType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
				return (global::Com.Google.Protobuf.Descriptors.JavaType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Protobuf.Descriptors.JavaType));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']"
		[global::Android.Runtime.Register ("com/google/protobuf/Descriptors$FieldDescriptor$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr BOOL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='BOOL']"
			[Register ("BOOL")]
			public static global::Com.Google.Protobuf.Descriptors.Type Bool {
				get {
					if (BOOL_jfieldId == IntPtr.Zero)
						BOOL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOL", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BOOL_jfieldId == IntPtr.Zero)
						BOOL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOL", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BOOL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BYTES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='BYTES']"
			[Register ("BYTES")]
			public static global::Com.Google.Protobuf.Descriptors.Type Bytes {
				get {
					if (BYTES_jfieldId == IntPtr.Zero)
						BYTES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTES", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BYTES_jfieldId == IntPtr.Zero)
						BYTES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTES", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BYTES_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DOUBLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='DOUBLE']"
			[Register ("DOUBLE")]
			public static global::Com.Google.Protobuf.Descriptors.Type Double {
				get {
					if (DOUBLE_jfieldId == IntPtr.Zero)
						DOUBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOUBLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DOUBLE_jfieldId == IntPtr.Zero)
						DOUBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DOUBLE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ENUM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='ENUM']"
			[Register ("ENUM")]
			public static global::Com.Google.Protobuf.Descriptors.Type Enum {
				get {
					if (ENUM_jfieldId == IntPtr.Zero)
						ENUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENUM", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENUM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ENUM_jfieldId == IntPtr.Zero)
						ENUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENUM", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ENUM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FIXED32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='FIXED32']"
			[Register ("FIXED32")]
			public static global::Com.Google.Protobuf.Descriptors.Type Fixed32 {
				get {
					if (FIXED32_jfieldId == IntPtr.Zero)
						FIXED32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIXED32", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIXED32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FIXED32_jfieldId == IntPtr.Zero)
						FIXED32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIXED32", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FIXED32_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FIXED64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='FIXED64']"
			[Register ("FIXED64")]
			public static global::Com.Google.Protobuf.Descriptors.Type Fixed64 {
				get {
					if (FIXED64_jfieldId == IntPtr.Zero)
						FIXED64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIXED64", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIXED64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FIXED64_jfieldId == IntPtr.Zero)
						FIXED64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIXED64", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FIXED64_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FLOAT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='FLOAT']"
			[Register ("FLOAT")]
			public static global::Com.Google.Protobuf.Descriptors.Type Float {
				get {
					if (FLOAT_jfieldId == IntPtr.Zero)
						FLOAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOAT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FLOAT_jfieldId == IntPtr.Zero)
						FLOAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FLOAT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr GROUP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='GROUP']"
			[Register ("GROUP")]
			public static global::Com.Google.Protobuf.Descriptors.Type Group {
				get {
					if (GROUP_jfieldId == IntPtr.Zero)
						GROUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROUP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GROUP_jfieldId == IntPtr.Zero)
						GROUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GROUP_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INT32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='INT32']"
			[Register ("INT32")]
			public static global::Com.Google.Protobuf.Descriptors.Type Int32 {
				get {
					if (INT32_jfieldId == IntPtr.Zero)
						INT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT32", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INT32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INT32_jfieldId == IntPtr.Zero)
						INT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT32", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INT32_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INT64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='INT64']"
			[Register ("INT64")]
			public static global::Com.Google.Protobuf.Descriptors.Type Int64 {
				get {
					if (INT64_jfieldId == IntPtr.Zero)
						INT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT64", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INT64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INT64_jfieldId == IntPtr.Zero)
						INT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT64", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INT64_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='MESSAGE']"
			[Register ("MESSAGE")]
			public static global::Com.Google.Protobuf.Descriptors.Type Message {
				get {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MESSAGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SFIXED32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='SFIXED32']"
			[Register ("SFIXED32")]
			public static global::Com.Google.Protobuf.Descriptors.Type Sfixed32 {
				get {
					if (SFIXED32_jfieldId == IntPtr.Zero)
						SFIXED32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SFIXED32", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SFIXED32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SFIXED32_jfieldId == IntPtr.Zero)
						SFIXED32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SFIXED32", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SFIXED32_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SFIXED64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='SFIXED64']"
			[Register ("SFIXED64")]
			public static global::Com.Google.Protobuf.Descriptors.Type Sfixed64 {
				get {
					if (SFIXED64_jfieldId == IntPtr.Zero)
						SFIXED64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SFIXED64", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SFIXED64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SFIXED64_jfieldId == IntPtr.Zero)
						SFIXED64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SFIXED64", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SFIXED64_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SINT32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='SINT32']"
			[Register ("SINT32")]
			public static global::Com.Google.Protobuf.Descriptors.Type Sint32 {
				get {
					if (SINT32_jfieldId == IntPtr.Zero)
						SINT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINT32", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINT32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SINT32_jfieldId == IntPtr.Zero)
						SINT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINT32", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SINT32_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SINT64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='SINT64']"
			[Register ("SINT64")]
			public static global::Com.Google.Protobuf.Descriptors.Type Sint64 {
				get {
					if (SINT64_jfieldId == IntPtr.Zero)
						SINT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINT64", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINT64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SINT64_jfieldId == IntPtr.Zero)
						SINT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINT64", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SINT64_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='STRING']"
			[Register ("STRING")]
			public static global::Com.Google.Protobuf.Descriptors.Type String {
				get {
					if (STRING_jfieldId == IntPtr.Zero)
						STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STRING_jfieldId == IntPtr.Zero)
						STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STRING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UINT32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='UINT32']"
			[Register ("UINT32")]
			public static global::Com.Google.Protobuf.Descriptors.Type Uint32 {
				get {
					if (UINT32_jfieldId == IntPtr.Zero)
						UINT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UINT32", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UINT32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UINT32_jfieldId == IntPtr.Zero)
						UINT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UINT32", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UINT32_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UINT64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/field[@name='UINT64']"
			[Register ("UINT64")]
			public static global::Com.Google.Protobuf.Descriptors.Type Uint64 {
				get {
					if (UINT64_jfieldId == IntPtr.Zero)
						UINT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UINT64", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UINT64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UINT64_jfieldId == IntPtr.Zero)
						UINT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UINT64", "Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UINT64_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/Descriptors$FieldDescriptor$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getJavaType;
			public global::Com.Google.Protobuf.Descriptors.JavaType JavaType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/method[@name='getJavaType' and count(parameter)=0]"
				[Register ("getJavaType", "()Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;", "GetGetJavaTypeHandler")]
				get {
					if (id_getJavaType == IntPtr.Zero)
						id_getJavaType = JNIEnv.GetMethodID (class_ref, "getJavaType", "()Lcom/google/protobuf/Descriptors$FieldDescriptor$JavaType;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.JavaType> (JNIEnv.CallObjectMethod  (Handle, id_getJavaType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;", "")]
			public static global::Com.Google.Protobuf.Descriptors.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.Descriptors.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FieldDescriptor.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;", "")]
			public static global::Com.Google.Protobuf.Descriptors.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/protobuf/Descriptors$FieldDescriptor$Type;");
				return (global::Com.Google.Protobuf.Descriptors.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Protobuf.Descriptors.Type));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']"
		[global::Android.Runtime.Register ("com/google/protobuf/Descriptors$FileDescriptor", DoNotGenerateAcw=true)]
		public sealed partial class FileDescriptor : global::Java.Lang.Object {

			// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.protobuf']/interface[@name='Descriptors.FileDescriptor.InternalDescriptorAssigner']"
			[Register ("com/google/protobuf/Descriptors$FileDescriptor$InternalDescriptorAssigner", "", "Com.Google.Protobuf.Descriptors/FileDescriptor/IInternalDescriptorAssignerInvoker")]
			public partial interface IInternalDescriptorAssigner : IJavaObject {

				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='Descriptors.FileDescriptor.InternalDescriptorAssigner']/method[@name='assignDescriptors' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.Descriptors.FileDescriptor']]"
				[Register ("assignDescriptors", "(Lcom/google/protobuf/Descriptors$FileDescriptor;)Lcom/google/protobuf/ExtensionRegistry;", "GetAssignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_Handler:Com.Google.Protobuf.Descriptors/FileDescriptor/IInternalDescriptorAssignerInvoker, UMengSdkMessage")]
				global::Com.Google.Protobuf.ExtensionRegistry AssignDescriptors (global::Com.Google.Protobuf.Descriptors.FileDescriptor p0);

			}

			[global::Android.Runtime.Register ("com/google/protobuf/Descriptors$FileDescriptor$InternalDescriptorAssigner", DoNotGenerateAcw=true)]
			internal class IInternalDescriptorAssignerInvoker : global::Java.Lang.Object, IInternalDescriptorAssigner {

				static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/protobuf/Descriptors$FileDescriptor$InternalDescriptorAssigner");
				IntPtr class_ref;

				public static IInternalDescriptorAssigner GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IInternalDescriptorAssigner> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
									JNIEnv.GetClassNameFromInstance (handle), "com.google.protobuf.Descriptors.FileDescriptor.InternalDescriptorAssigner"));
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IInternalDescriptorAssignerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
				{
					IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
					this.class_ref = JNIEnv.NewGlobalRef (local_ref);
					JNIEnv.DeleteLocalRef (local_ref);
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override System.Type ThresholdType {
					get { return typeof (IInternalDescriptorAssignerInvoker); }
				}

				static Delegate cb_assignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_;
#pragma warning disable 0169
				static Delegate GetAssignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_Handler ()
				{
					if (cb_assignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_ == null)
						cb_assignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AssignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_);
					return cb_assignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_;
				}

				static IntPtr n_AssignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
				{
					global::Com.Google.Protobuf.Descriptors.FileDescriptor.IInternalDescriptorAssigner __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.FileDescriptor.IInternalDescriptorAssigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					global::Com.Google.Protobuf.Descriptors.FileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.FileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AssignDescriptors (p0));
					return __ret;
				}
#pragma warning restore 0169

				IntPtr id_assignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_;
				public global::Com.Google.Protobuf.ExtensionRegistry AssignDescriptors (global::Com.Google.Protobuf.Descriptors.FileDescriptor p0)
				{
					if (id_assignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_ == IntPtr.Zero)
						id_assignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_ = JNIEnv.GetMethodID (class_ref, "assignDescriptors", "(Lcom/google/protobuf/Descriptors$FileDescriptor;)Lcom/google/protobuf/ExtensionRegistry;");
					global::Com.Google.Protobuf.ExtensionRegistry __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistry> (JNIEnv.CallObjectMethod (Handle, id_assignDescriptors_Lcom_google_protobuf_Descriptors_FileDescriptor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

			}


			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/Descriptors$FileDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FileDescriptor); }
			}

			internal FileDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDependencies;
			public global::System.Collections.Generic.IList<global::Com.Google.Protobuf.Descriptors.FileDescriptor> Dependencies {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='getDependencies' and count(parameter)=0]"
				[Register ("getDependencies", "()Ljava/util/List;", "GetGetDependenciesHandler")]
				get {
					if (id_getDependencies == IntPtr.Zero)
						id_getDependencies = JNIEnv.GetMethodID (class_ref, "getDependencies", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Google.Protobuf.Descriptors.FileDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getDependencies), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getEnumTypes;
			public global::System.Collections.Generic.IList<global::Com.Google.Protobuf.Descriptors.EnumDescriptor> EnumTypes {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='getEnumTypes' and count(parameter)=0]"
				[Register ("getEnumTypes", "()Ljava/util/List;", "GetGetEnumTypesHandler")]
				get {
					if (id_getEnumTypes == IntPtr.Zero)
						id_getEnumTypes = JNIEnv.GetMethodID (class_ref, "getEnumTypes", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Google.Protobuf.Descriptors.EnumDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getEnumTypes), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getMessageTypes;
			public global::System.Collections.Generic.IList<global::Com.Google.Protobuf.Descriptors.Descriptor> MessageTypes {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='getMessageTypes' and count(parameter)=0]"
				[Register ("getMessageTypes", "()Ljava/util/List;", "GetGetMessageTypesHandler")]
				get {
					if (id_getMessageTypes == IntPtr.Zero)
						id_getMessageTypes = JNIEnv.GetMethodID (class_ref, "getMessageTypes", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Google.Protobuf.Descriptors.Descriptor>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMessageTypes), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getName;
			public string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getPackage;
			public string Package {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='getPackage' and count(parameter)=0]"
				[Register ("getPackage", "()Ljava/lang/String;", "GetGetPackageHandler")]
				get {
					if (id_getPackage == IntPtr.Zero)
						id_getPackage = JNIEnv.GetMethodID (class_ref, "getPackage", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPackage), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getPublicDependencies;
			public global::System.Collections.Generic.IList<global::Com.Google.Protobuf.Descriptors.FileDescriptor> PublicDependencies {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='getPublicDependencies' and count(parameter)=0]"
				[Register ("getPublicDependencies", "()Ljava/util/List;", "GetGetPublicDependenciesHandler")]
				get {
					if (id_getPublicDependencies == IntPtr.Zero)
						id_getPublicDependencies = JNIEnv.GetMethodID (class_ref, "getPublicDependencies", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Google.Protobuf.Descriptors.FileDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPublicDependencies), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getServices;
			public global::System.Collections.Generic.IList<global::Com.Google.Protobuf.Descriptors.ServiceDescriptor> Services {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='getServices' and count(parameter)=0]"
				[Register ("getServices", "()Ljava/util/List;", "GetGetServicesHandler")]
				get {
					if (id_getServices == IntPtr.Zero)
						id_getServices = JNIEnv.GetMethodID (class_ref, "getServices", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Google.Protobuf.Descriptors.ServiceDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getServices), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_findEnumTypeByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='findEnumTypeByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findEnumTypeByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$EnumDescriptor;", "")]
			public global::Com.Google.Protobuf.Descriptors.EnumDescriptor FindEnumTypeByName (string p0)
			{
				if (id_findEnumTypeByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findEnumTypeByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findEnumTypeByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$EnumDescriptor;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.Descriptors.EnumDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.EnumDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_findEnumTypeByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_findMessageTypeByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='findMessageTypeByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findMessageTypeByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$Descriptor;", "")]
			public global::Com.Google.Protobuf.Descriptors.Descriptor FindMessageTypeByName (string p0)
			{
				if (id_findMessageTypeByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findMessageTypeByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findMessageTypeByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$Descriptor;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.Descriptors.Descriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Descriptor> (JNIEnv.CallObjectMethod  (Handle, id_findMessageTypeByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_findServiceByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='findServiceByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findServiceByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$ServiceDescriptor;", "")]
			public global::Com.Google.Protobuf.Descriptors.ServiceDescriptor FindServiceByName (string p0)
			{
				if (id_findServiceByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findServiceByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findServiceByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$ServiceDescriptor;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.Descriptors.ServiceDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.ServiceDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_findServiceByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_internalBuildGeneratedFileFrom_arrayLjava_lang_String_arrayLcom_google_protobuf_Descriptors_FileDescriptor_Lcom_google_protobuf_Descriptors_FileDescriptor_InternalDescriptorAssigner_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.FileDescriptor']/method[@name='internalBuildGeneratedFileFrom' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.google.protobuf.Descriptors.FileDescriptor[]'] and parameter[3][@type='com.google.protobuf.Descriptors.FileDescriptor.InternalDescriptorAssigner']]"
			[Register ("internalBuildGeneratedFileFrom", "([Ljava/lang/String;[Lcom/google/protobuf/Descriptors$FileDescriptor;Lcom/google/protobuf/Descriptors$FileDescriptor$InternalDescriptorAssigner;)V", "")]
			public static void InternalBuildGeneratedFileFrom (string[] p0, global::Com.Google.Protobuf.Descriptors.FileDescriptor[] p1, global::Com.Google.Protobuf.Descriptors.FileDescriptor.IInternalDescriptorAssigner p2)
			{
				if (id_internalBuildGeneratedFileFrom_arrayLjava_lang_String_arrayLcom_google_protobuf_Descriptors_FileDescriptor_Lcom_google_protobuf_Descriptors_FileDescriptor_InternalDescriptorAssigner_ == IntPtr.Zero)
					id_internalBuildGeneratedFileFrom_arrayLjava_lang_String_arrayLcom_google_protobuf_Descriptors_FileDescriptor_Lcom_google_protobuf_Descriptors_FileDescriptor_InternalDescriptorAssigner_ = JNIEnv.GetStaticMethodID (class_ref, "internalBuildGeneratedFileFrom", "([Ljava/lang/String;[Lcom/google/protobuf/Descriptors$FileDescriptor;Lcom/google/protobuf/Descriptors$FileDescriptor$InternalDescriptorAssigner;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_internalBuildGeneratedFileFrom_arrayLjava_lang_String_arrayLcom_google_protobuf_Descriptors_FileDescriptor_Lcom_google_protobuf_Descriptors_FileDescriptor_InternalDescriptorAssigner_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.MethodDescriptor']"
		[global::Android.Runtime.Register ("com/google/protobuf/Descriptors$MethodDescriptor", DoNotGenerateAcw=true)]
		public sealed partial class MethodDescriptor : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/Descriptors$MethodDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MethodDescriptor); }
			}

			internal MethodDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getFile;
			public global::Com.Google.Protobuf.Descriptors.FileDescriptor File {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.MethodDescriptor']/method[@name='getFile' and count(parameter)=0]"
				[Register ("getFile", "()Lcom/google/protobuf/Descriptors$FileDescriptor;", "GetGetFileHandler")]
				get {
					if (id_getFile == IntPtr.Zero)
						id_getFile = JNIEnv.GetMethodID (class_ref, "getFile", "()Lcom/google/protobuf/Descriptors$FileDescriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.FileDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getFile), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getFullName;
			public string FullName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.MethodDescriptor']/method[@name='getFullName' and count(parameter)=0]"
				[Register ("getFullName", "()Ljava/lang/String;", "GetGetFullNameHandler")]
				get {
					if (id_getFullName == IntPtr.Zero)
						id_getFullName = JNIEnv.GetMethodID (class_ref, "getFullName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFullName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getIndex;
			public int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.MethodDescriptor']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					if (id_getIndex == IntPtr.Zero)
						id_getIndex = JNIEnv.GetMethodID (class_ref, "getIndex", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getIndex);
				}
			}

			static IntPtr id_getInputType;
			public global::Com.Google.Protobuf.Descriptors.Descriptor InputType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.MethodDescriptor']/method[@name='getInputType' and count(parameter)=0]"
				[Register ("getInputType", "()Lcom/google/protobuf/Descriptors$Descriptor;", "GetGetInputTypeHandler")]
				get {
					if (id_getInputType == IntPtr.Zero)
						id_getInputType = JNIEnv.GetMethodID (class_ref, "getInputType", "()Lcom/google/protobuf/Descriptors$Descriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Descriptor> (JNIEnv.CallObjectMethod  (Handle, id_getInputType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getName;
			public string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.MethodDescriptor']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getOutputType;
			public global::Com.Google.Protobuf.Descriptors.Descriptor OutputType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.MethodDescriptor']/method[@name='getOutputType' and count(parameter)=0]"
				[Register ("getOutputType", "()Lcom/google/protobuf/Descriptors$Descriptor;", "GetGetOutputTypeHandler")]
				get {
					if (id_getOutputType == IntPtr.Zero)
						id_getOutputType = JNIEnv.GetMethodID (class_ref, "getOutputType", "()Lcom/google/protobuf/Descriptors$Descriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.Descriptor> (JNIEnv.CallObjectMethod  (Handle, id_getOutputType), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getService;
			public global::Com.Google.Protobuf.Descriptors.ServiceDescriptor Service {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.MethodDescriptor']/method[@name='getService' and count(parameter)=0]"
				[Register ("getService", "()Lcom/google/protobuf/Descriptors$ServiceDescriptor;", "GetGetServiceHandler")]
				get {
					if (id_getService == IntPtr.Zero)
						id_getService = JNIEnv.GetMethodID (class_ref, "getService", "()Lcom/google/protobuf/Descriptors$ServiceDescriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.ServiceDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getService), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.ServiceDescriptor']"
		[global::Android.Runtime.Register ("com/google/protobuf/Descriptors$ServiceDescriptor", DoNotGenerateAcw=true)]
		public sealed partial class ServiceDescriptor : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/Descriptors$ServiceDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ServiceDescriptor); }
			}

			internal ServiceDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getFile;
			public global::Com.Google.Protobuf.Descriptors.FileDescriptor File {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.ServiceDescriptor']/method[@name='getFile' and count(parameter)=0]"
				[Register ("getFile", "()Lcom/google/protobuf/Descriptors$FileDescriptor;", "GetGetFileHandler")]
				get {
					if (id_getFile == IntPtr.Zero)
						id_getFile = JNIEnv.GetMethodID (class_ref, "getFile", "()Lcom/google/protobuf/Descriptors$FileDescriptor;");
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.FileDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getFile), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getFullName;
			public string FullName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.ServiceDescriptor']/method[@name='getFullName' and count(parameter)=0]"
				[Register ("getFullName", "()Ljava/lang/String;", "GetGetFullNameHandler")]
				get {
					if (id_getFullName == IntPtr.Zero)
						id_getFullName = JNIEnv.GetMethodID (class_ref, "getFullName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFullName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getIndex;
			public int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.ServiceDescriptor']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					if (id_getIndex == IntPtr.Zero)
						id_getIndex = JNIEnv.GetMethodID (class_ref, "getIndex", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getIndex);
				}
			}

			static IntPtr id_getMethods;
			public global::System.Collections.Generic.IList<global::Com.Google.Protobuf.Descriptors.MethodDescriptor> Methods {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.ServiceDescriptor']/method[@name='getMethods' and count(parameter)=0]"
				[Register ("getMethods", "()Ljava/util/List;", "GetGetMethodsHandler")]
				get {
					if (id_getMethods == IntPtr.Zero)
						id_getMethods = JNIEnv.GetMethodID (class_ref, "getMethods", "()Ljava/util/List;");
					return global::Android.Runtime.JavaList<global::Com.Google.Protobuf.Descriptors.MethodDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMethods), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getName;
			public string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.ServiceDescriptor']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_findMethodByName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors.ServiceDescriptor']/method[@name='findMethodByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("findMethodByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$MethodDescriptor;", "")]
			public global::Com.Google.Protobuf.Descriptors.MethodDescriptor FindMethodByName (string p0)
			{
				if (id_findMethodByName_Ljava_lang_String_ == IntPtr.Zero)
					id_findMethodByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findMethodByName", "(Ljava/lang/String;)Lcom/google/protobuf/Descriptors$MethodDescriptor;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.Descriptors.MethodDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.MethodDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_findMethodByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/Descriptors", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Descriptors); }
		}

		internal Descriptors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.protobuf']/class[@name='Descriptors']/constructor[@name='Descriptors' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Descriptors () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Descriptors)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

	}
}
