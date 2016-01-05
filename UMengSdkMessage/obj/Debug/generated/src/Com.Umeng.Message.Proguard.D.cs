using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='D']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/D", DoNotGenerateAcw=true)]
	public partial class D : global::Java.Lang.Object, global::Com.Umeng.Message.Proguard.IA {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/D", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (D); }
		}

		protected D (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Umeng.Message.Proguard.D __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='D']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		public virtual void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()V"));
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
			global::Com.Umeng.Message.Proguard.D __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='D']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("a", "(Landroid/app/Activity;)V", "GetA_Landroid_app_Activity_Handler")]
		public virtual void A (global::Android.App.Activity p0)
		{
			if (id_a_Landroid_app_Activity_ == IntPtr.Zero)
				id_a_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/app/Activity;)V"), new JValue (p0));
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
			global::Com.Umeng.Message.Proguard.D __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='D']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("a", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetA_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual void A (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_a_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_a_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/app/Activity;Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_app_Activity_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_A_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.D __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='D']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)V", "GetA_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Umeng.Message.Proguard.D __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='D']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public virtual void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_b);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()V"));
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
			global::Com.Umeng.Message.Proguard.D __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		static IntPtr id_b_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='D']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("b", "(Landroid/app/Activity;)V", "GetB_Landroid_app_Activity_Handler")]
		public virtual void B (global::Android.App.Activity p0)
		{
			if (id_b_Landroid_app_Activity_ == IntPtr.Zero)
				id_b_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_b_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Landroid/app/Activity;)V"), new JValue (p0));
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
			global::Com.Umeng.Message.Proguard.D __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.B (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_b_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='D']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("b", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetB_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual void B (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_b_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_b_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/app/Activity;Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_b_Landroid_app_Activity_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), new JValue (p0), new JValue (p1));
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='D']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/umeng/message/proguard/D;", "")]
		public static global::Com.Umeng.Message.Proguard.D C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetStaticMethodID (class_ref, "c", "()Lcom/umeng/message/proguard/D;");
			return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.D> (JNIEnv.CallStaticObjectMethod  (class_ref, id_c), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Umeng.Message.Proguard.D __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.C (p0);
		}
#pragma warning restore 0169

		static IntPtr id_c_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='D']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("c", "(Landroid/app/Activity;)V", "GetC_Landroid_app_Activity_Handler")]
		public virtual void C (global::Android.App.Activity p0)
		{
			if (id_c_Landroid_app_Activity_ == IntPtr.Zero)
				id_c_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "c", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_c_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "c", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

	}
}
