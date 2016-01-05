using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='C']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/C", DoNotGenerateAcw=true)]
	public partial class C : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/C", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (C); }
		}

		protected C (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Landroid_app_Application_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='C']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("a", "(Landroid/app/Application;)V", "")]
		public static void A (global::Android.App.Application p0)
		{
			if (id_a_Landroid_app_Application_ == IntPtr.Zero)
				id_a_Landroid_app_Application_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/app/Application;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_app_Application_, new JValue (p0));
		}

		static IntPtr id_a_Lcom_umeng_message_proguard_A_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='C']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.umeng.message.proguard.A']]"
		[Register ("a", "(Lcom/umeng/message/proguard/A;)V", "")]
		public static void A (global::Com.Umeng.Message.Proguard.IA p0)
		{
			if (id_a_Lcom_umeng_message_proguard_A_ == IntPtr.Zero)
				id_a_Lcom_umeng_message_proguard_A_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/umeng/message/proguard/A;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Lcom_umeng_message_proguard_A_, new JValue (p0));
		}

	}
}
