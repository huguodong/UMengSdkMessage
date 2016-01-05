using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='SharedPreferenceHelper']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/SharedPreferenceHelper", DoNotGenerateAcw=true)]
	public partial class SharedPreferenceHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/SharedPreferenceHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SharedPreferenceHelper); }
		}

		protected SharedPreferenceHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='SharedPreferenceHelper']/constructor[@name='SharedPreferenceHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SharedPreferenceHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SharedPreferenceHelper)) {
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

		static IntPtr id_apply_Landroid_content_SharedPreferences_Editor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='SharedPreferenceHelper']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='android.content.SharedPreferences.Editor']]"
		[Register ("apply", "(Landroid/content/SharedPreferences$Editor;)V", "")]
		public static void Apply (global::Android.Content.ISharedPreferencesEditor p0)
		{
			if (id_apply_Landroid_content_SharedPreferences_Editor_ == IntPtr.Zero)
				id_apply_Landroid_content_SharedPreferences_Editor_ = JNIEnv.GetStaticMethodID (class_ref, "apply", "(Landroid/content/SharedPreferences$Editor;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_apply_Landroid_content_SharedPreferences_Editor_, new JValue (p0));
		}

	}
}
