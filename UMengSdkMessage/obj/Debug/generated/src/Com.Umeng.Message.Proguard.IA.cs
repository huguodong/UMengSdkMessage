using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='A']"
	[Register ("com/umeng/message/proguard/A", "", "Com.Umeng.Message.Proguard.IAInvoker")]
	public partial interface IA : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='A']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler:Com.Umeng.Message.Proguard.IAInvoker, UMengSdkMessage")]
		void A ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='A']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("a", "(Landroid/app/Activity;)V", "GetA_Landroid_app_Activity_Handler:Com.Umeng.Message.Proguard.IAInvoker, UMengSdkMessage")]
		void A (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='A']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("a", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetA_Landroid_app_Activity_Landroid_os_Bundle_Handler:Com.Umeng.Message.Proguard.IAInvoker, UMengSdkMessage")]
		void A (global::Android.App.Activity p0, global::Android.OS.Bundle p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='A']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler:Com.Umeng.Message.Proguard.IAInvoker, UMengSdkMessage")]
		void B ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='A']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("b", "(Landroid/app/Activity;)V", "GetB_Landroid_app_Activity_Handler:Com.Umeng.Message.Proguard.IAInvoker, UMengSdkMessage")]
		void B (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='A']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("b", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetB_Landroid_app_Activity_Landroid_os_Bundle_Handler:Com.Umeng.Message.Proguard.IAInvoker, UMengSdkMessage")]
		void B (global::Android.App.Activity p0, global::Android.OS.Bundle p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='A']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("c", "(Landroid/app/Activity;)V", "GetC_Landroid_app_Activity_Handler:Com.Umeng.Message.Proguard.IAInvoker, UMengSdkMessage")]
		void C (global::Android.App.Activity p0);

	}

	[global::Android.Runtime.Register ("com/umeng/message/proguard/A", DoNotGenerateAcw=true)]
	internal class IAInvoker : global::Java.Lang.Object, IA {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/message/proguard/A");
		IntPtr class_ref;

		public static IA GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IA> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.message.proguard.A"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAInvoker); }
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static void n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.IA __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		IntPtr id_a;
		public void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod (Handle, id_a);
		}

		static Delegate cb_a_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_app_Activity_Handler ()
		{
			if (cb_a_Landroid_app_Activity_ == null)
				cb_a_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Landroid_app_Activity_);
			return cb_a_Landroid_app_Activity_;
		}

		static void n_A_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.IA __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Landroid_app_Activity_;
		public void A (global::Android.App.Activity p0)
		{
			if (id_a_Landroid_app_Activity_ == IntPtr.Zero)
				id_a_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/app/Activity;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Landroid_app_Activity_, new JValue (p0));
		}

		static Delegate cb_a_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_a_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_a_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_a_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_A_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.IA __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_a_Landroid_app_Activity_Landroid_os_Bundle_;
		public void A (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_a_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_a_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_Landroid_app_Activity_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.IA __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		IntPtr id_b;
		public void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			JNIEnv.CallVoidMethod (Handle, id_b);
		}

		static Delegate cb_b_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetB_Landroid_app_Activity_Handler ()
		{
			if (cb_b_Landroid_app_Activity_ == null)
				cb_b_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_B_Landroid_app_Activity_);
			return cb_b_Landroid_app_Activity_;
		}

		static void n_B_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.IA __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		IntPtr id_b_Landroid_app_Activity_;
		public void B (global::Android.App.Activity p0)
		{
			if (id_b_Landroid_app_Activity_ == IntPtr.Zero)
				id_b_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/app/Activity;)V");
			JNIEnv.CallVoidMethod (Handle, id_b_Landroid_app_Activity_, new JValue (p0));
		}

		static Delegate cb_b_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetB_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_b_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_b_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_B_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_b_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_B_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.IA __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.B (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_b_Landroid_app_Activity_Landroid_os_Bundle_;
		public void B (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_b_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_b_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod (Handle, id_b_Landroid_app_Activity_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_c_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetC_Landroid_app_Activity_Handler ()
		{
			if (cb_c_Landroid_app_Activity_ == null)
				cb_c_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_C_Landroid_app_Activity_);
			return cb_c_Landroid_app_Activity_;
		}

		static void n_C_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.IA __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.C (p0);
		}
#pragma warning restore 0169

		IntPtr id_c_Landroid_app_Activity_;
		public void C (global::Android.App.Activity p0)
		{
			if (id_c_Landroid_app_Activity_ == IntPtr.Zero)
				id_c_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "c", "(Landroid/app/Activity;)V");
			JNIEnv.CallVoidMethod (Handle, id_c_Landroid_app_Activity_, new JValue (p0));
		}

	}

}
