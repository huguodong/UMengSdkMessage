using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='B']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/B", DoNotGenerateAcw=true)]
	public partial class B : global::Java.Lang.Object, global::Android.App.Application.IActivityLifecycleCallbacks {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/B", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (B); }
		}

		protected B (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='B']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/umeng/message/proguard/B;", "")]
		public static global::Com.Umeng.Message.Proguard.B A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Lcom/umeng/message/proguard/B;");
			return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.B> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_a_Lcom_umeng_message_proguard_A_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_umeng_message_proguard_A_Handler ()
		{
			if (cb_a_Lcom_umeng_message_proguard_A_ == null)
				cb_a_Lcom_umeng_message_proguard_A_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_umeng_message_proguard_A_);
			return cb_a_Lcom_umeng_message_proguard_A_;
		}

		static void n_A_Lcom_umeng_message_proguard_A_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.B __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Proguard.IA p0 = (global::Com.Umeng.Message.Proguard.IA)global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IA> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Lcom_umeng_message_proguard_A_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='B']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.umeng.message.proguard.A']]"
		[Register ("a", "(Lcom/umeng/message/proguard/A;)V", "GetA_Lcom_umeng_message_proguard_A_Handler")]
		public virtual void A (global::Com.Umeng.Message.Proguard.IA p0)
		{
			if (id_a_Lcom_umeng_message_proguard_A_ == IntPtr.Zero)
				id_a_Lcom_umeng_message_proguard_A_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/umeng/message/proguard/A;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_umeng_message_proguard_A_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Lcom/umeng/message/proguard/A;)V"), new JValue (p0));
		}

		static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.B __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityCreated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='B']/method[@name='onActivityCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual void OnActivityCreated (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityDestroyed_Landroid_app_Activity_ == null)
				cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityDestroyed_Landroid_app_Activity_);
			return cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		static void n_OnActivityDestroyed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.B __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityDestroyed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityDestroyed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='B']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
		public virtual void OnActivityDestroyed (global::Android.App.Activity p0)
		{
			if (id_onActivityDestroyed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityDestroyed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityDestroyed", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityDestroyed_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityDestroyed", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

		static Delegate cb_onActivityPaused_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityPaused_Landroid_app_Activity_ == null)
				cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityPaused_Landroid_app_Activity_);
			return cb_onActivityPaused_Landroid_app_Activity_;
		}

		static void n_OnActivityPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.B __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityPaused (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityPaused_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='B']/method[@name='onActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
		public virtual void OnActivityPaused (global::Android.App.Activity p0)
		{
			if (id_onActivityPaused_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityPaused_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityPaused", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityPaused_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityPaused", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

		static Delegate cb_onActivityResumed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityResumed_Landroid_app_Activity_ == null)
				cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityResumed_Landroid_app_Activity_);
			return cb_onActivityResumed_Landroid_app_Activity_;
		}

		static void n_OnActivityResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.B __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResumed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResumed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='B']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
		public virtual void OnActivityResumed (global::Android.App.Activity p0)
		{
			if (id_onActivityResumed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityResumed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityResumed", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityResumed_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResumed", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

		static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.B __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnActivitySaveInstanceState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='B']/method[@name='onActivitySaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual void OnActivitySaveInstanceState (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onActivityStarted_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStarted_Landroid_app_Activity_ == null)
				cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStarted_Landroid_app_Activity_);
			return cb_onActivityStarted_Landroid_app_Activity_;
		}

		static void n_OnActivityStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.B __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityStarted_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='B']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
		public virtual void OnActivityStarted (global::Android.App.Activity p0)
		{
			if (id_onActivityStarted_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityStarted_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStarted", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityStarted_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStarted", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

		static Delegate cb_onActivityStopped_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStopped_Landroid_app_Activity_ == null)
				cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStopped_Landroid_app_Activity_);
			return cb_onActivityStopped_Landroid_app_Activity_;
		}

		static void n_OnActivityStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.B __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStopped (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityStopped_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='B']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
		public virtual void OnActivityStopped (global::Android.App.Activity p0)
		{
			if (id_onActivityStopped_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityStopped_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStopped", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityStopped_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStopped", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

	}
}
