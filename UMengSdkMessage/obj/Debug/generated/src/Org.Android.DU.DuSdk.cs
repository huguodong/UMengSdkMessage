using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.DU {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.du']/class[@name='DuSdk']"
	[global::Android.Runtime.Register ("org/android/du/DuSdk", DoNotGenerateAcw=true)]
	public partial class DuSdk : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/du/DuSdk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DuSdk); }
		}

		protected DuSdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.du']/class[@name='DuSdk']/constructor[@name='DuSdk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DuSdk () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DuSdk)) {
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

		static IntPtr id_checkUpdateJar_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='DuSdk']/method[@name='checkUpdateJar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkUpdateJar", "(Landroid/content/Context;)Z", "")]
		public static bool CheckUpdateJar (global::Android.Content.Context p0)
		{
			if (id_checkUpdateJar_Landroid_content_Context_ == IntPtr.Zero)
				id_checkUpdateJar_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkUpdateJar", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkUpdateJar_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='DuSdk']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public static void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetStaticMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_destroy);
		}

		static IntPtr id_getUpdate_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='DuSdk']/method[@name='getUpdate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getUpdate", "(Landroid/content/Context;Ljava/lang/String;)Lorg/android/du/Update;", "")]
		public static global::Org.Android.DU.Update GetUpdate (global::Android.Content.Context p0, string p1)
		{
			if (id_getUpdate_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getUpdate_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getUpdate", "(Landroid/content/Context;Ljava/lang/String;)Lorg/android/du/Update;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Org.Android.DU.Update __ret = global::Java.Lang.Object.GetObject<global::Org.Android.DU.Update> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUpdate_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_setting_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='DuSdk']/method[@name='setting' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setting", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Setting (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_setting_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setting_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setting", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setting_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_unInit_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='DuSdk']/method[@name='unInit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unInit", "(Ljava/lang/String;)V", "")]
		public static void UnInit (string p0)
		{
			if (id_unInit_Ljava_lang_String_ == IntPtr.Zero)
				id_unInit_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unInit", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unInit_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
