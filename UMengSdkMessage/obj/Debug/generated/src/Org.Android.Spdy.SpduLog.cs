using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']"
	[global::Android.Runtime.Register ("org/android/spdy/spduLog", DoNotGenerateAcw=true)]
	public partial class SpduLog : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/spduLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpduLog); }
		}

		protected SpduLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/constructor[@name='spduLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SpduLog () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SpduLog)) {
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

		static IntPtr id_getSavedTraffic;
		public static long SavedTraffic {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/method[@name='getSavedTraffic' and count(parameter)=0]"
			[Register ("getSavedTraffic", "()J", "GetGetSavedTrafficHandler")]
			get {
				if (id_getSavedTraffic == IntPtr.Zero)
					id_getSavedTraffic = JNIEnv.GetStaticMethodID (class_ref, "getSavedTraffic", "()J");
				return JNIEnv.CallStaticLongMethod  (class_ref, id_getSavedTraffic);
			}
		}

		static IntPtr id_Logd_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/method[@name='Logd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Logd", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Logd (string p0, string p1)
		{
			if (id_Logd_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Logd_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Logd", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_Logd_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_Logd_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/method[@name='Logd' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("Logd", "(Ljava/lang/String;Ljava/lang/String;J)V", "")]
		public static void Logd (string p0, string p1, long p2)
		{
			if (id_Logd_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_Logd_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "Logd", "(Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_Logd_Ljava_lang_String_Ljava_lang_String_J, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_Loge_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/method[@name='Loge' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Loge", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Loge (string p0, string p1)
		{
			if (id_Loge_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Loge_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Loge", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_Loge_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_Logf_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/method[@name='Logf' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Logf", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Logf (string p0, string p1)
		{
			if (id_Logf_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Logf_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Logf", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_Logf_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_Logi_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/method[@name='Logi' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Logi", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Logi (string p0, string p1)
		{
			if (id_Logi_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Logi_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Logi", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_Logi_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_Logv_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/method[@name='Logv' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Logv", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Logv (string p0, string p1)
		{
			if (id_Logv_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Logv_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Logv", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_Logv_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_Logw_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/method[@name='Logw' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Logw", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Logw (string p0, string p1)
		{
			if (id_Logw_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Logw_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Logw", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_Logw_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_addTraffic_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/method[@name='addTraffic' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("addTraffic", "(J)V", "")]
		public static void AddTraffic (long p0)
		{
			if (id_addTraffic_J == IntPtr.Zero)
				id_addTraffic_J = JNIEnv.GetStaticMethodID (class_ref, "addTraffic", "(J)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_addTraffic_J, new JValue (p0));
		}

		static IntPtr id_now;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='spduLog']/method[@name='now' and count(parameter)=0]"
		[Register ("now", "()J", "")]
		public static long Now ()
		{
			if (id_now == IntPtr.Zero)
				id_now = JNIEnv.GetStaticMethodID (class_ref, "now", "()J");
			return JNIEnv.CallStaticLongMethod  (class_ref, id_now);
		}

	}
}
