using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SoInstallMgrSdk']"
	[global::Android.Runtime.Register ("org/android/spdy/SoInstallMgrSdk", DoNotGenerateAcw=true)]
	public partial class SoInstallMgrSdk : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SoInstallMgrSdk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SoInstallMgrSdk); }
		}

		protected SoInstallMgrSdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SoInstallMgrSdk']/constructor[@name='SoInstallMgrSdk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SoInstallMgrSdk () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SoInstallMgrSdk)) {
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

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SoInstallMgrSdk']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_initSo_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SoInstallMgrSdk']/method[@name='initSo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("initSo", "(Ljava/lang/String;I)Z", "")]
		public static bool InitSo (string p0, int p1)
		{
			if (id_initSo_Ljava_lang_String_I == IntPtr.Zero)
				id_initSo_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "initSo", "(Ljava/lang/String;I)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_initSo_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_initSo_Ljava_lang_String_ILjava_lang_ClassLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SoInstallMgrSdk']/method[@name='initSo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.ClassLoader']]"
		[Register ("initSo", "(Ljava/lang/String;ILjava/lang/ClassLoader;)Z", "")]
		public static bool InitSo (string p0, int p1, global::Java.Lang.ClassLoader p2)
		{
			if (id_initSo_Ljava_lang_String_ILjava_lang_ClassLoader_ == IntPtr.Zero)
				id_initSo_Ljava_lang_String_ILjava_lang_ClassLoader_ = JNIEnv.GetStaticMethodID (class_ref, "initSo", "(Ljava/lang/String;ILjava/lang/ClassLoader;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_initSo_Ljava_lang_String_ILjava_lang_ClassLoader_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
