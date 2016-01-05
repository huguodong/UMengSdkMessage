using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.client']/class[@name='Mode']"
	[global::Android.Runtime.Register ("org/android/agoo/client/Mode", DoNotGenerateAcw=true)]
	public sealed partial class Mode : global::Java.Lang.Enum {


		static IntPtr PREVIEW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/class[@name='Mode']/field[@name='PREVIEW']"
		[Register ("PREVIEW")]
		public static global::Org.Android.Agoo.Client.Mode Preview {
			get {
				if (PREVIEW_jfieldId == IntPtr.Zero)
					PREVIEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREVIEW", "Lorg/android/agoo/client/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREVIEW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PREVIEW_jfieldId == IntPtr.Zero)
					PREVIEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREVIEW", "Lorg/android/agoo/client/Mode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, PREVIEW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr RELEASE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/class[@name='Mode']/field[@name='RELEASE']"
		[Register ("RELEASE")]
		public static global::Org.Android.Agoo.Client.Mode Release {
			get {
				if (RELEASE_jfieldId == IntPtr.Zero)
					RELEASE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RELEASE", "Lorg/android/agoo/client/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RELEASE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (RELEASE_jfieldId == IntPtr.Zero)
					RELEASE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RELEASE", "Lorg/android/agoo/client/Mode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, RELEASE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr TAOBAO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/class[@name='Mode']/field[@name='TAOBAO']"
		[Register ("TAOBAO")]
		public static global::Org.Android.Agoo.Client.Mode Taobao {
			get {
				if (TAOBAO_jfieldId == IntPtr.Zero)
					TAOBAO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAOBAO", "Lorg/android/agoo/client/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAOBAO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAOBAO_jfieldId == IntPtr.Zero)
					TAOBAO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAOBAO", "Lorg/android/agoo/client/Mode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, TAOBAO_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr TEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/class[@name='Mode']/field[@name='TEST']"
		[Register ("TEST")]
		public static global::Org.Android.Agoo.Client.Mode Test {
			get {
				if (TEST_jfieldId == IntPtr.Zero)
					TEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEST", "Lorg/android/agoo/client/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TEST_jfieldId == IntPtr.Zero)
					TEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEST", "Lorg/android/agoo/client/Mode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, TEST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr TEST_SINGLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/class[@name='Mode']/field[@name='TEST_SINGLE']"
		[Register ("TEST_SINGLE")]
		public static global::Org.Android.Agoo.Client.Mode TestSingle {
			get {
				if (TEST_SINGLE_jfieldId == IntPtr.Zero)
					TEST_SINGLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEST_SINGLE", "Lorg/android/agoo/client/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEST_SINGLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TEST_SINGLE_jfieldId == IntPtr.Zero)
					TEST_SINGLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEST_SINGLE", "Lorg/android/agoo/client/Mode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, TEST_SINGLE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/client/Mode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Mode); }
		}

		internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='Mode']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getValue);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='Mode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/agoo/client/Mode;", "")]
		public static global::Org.Android.Agoo.Client.Mode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/agoo/client/Mode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Android.Agoo.Client.Mode __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.Mode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='Mode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/android/agoo/client/Mode;", "")]
		public static global::Org.Android.Agoo.Client.Mode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/agoo/client/Mode;");
			return (global::Org.Android.Agoo.Client.Mode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Agoo.Client.Mode));
		}

	}
}
