using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='X']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/X", DoNotGenerateAcw=true)]
	public partial class X : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/X", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (X); }
		}

		protected X (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='X']/constructor[@name='X' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public X () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (X)) {
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
			global::Com.Umeng.Message.Proguard.X __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.X> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='X']/method[@name='a' and count(parameter)=0]"
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

		static Delegate cb_a_Lcom_umeng_message_proguard_W_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_umeng_message_proguard_W_Handler ()
		{
			if (cb_a_Lcom_umeng_message_proguard_W_ == null)
				cb_a_Lcom_umeng_message_proguard_W_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_umeng_message_proguard_W_);
			return cb_a_Lcom_umeng_message_proguard_W_;
		}

		static void n_A_Lcom_umeng_message_proguard_W_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.X __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.X> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Proguard.W p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.W> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Lcom_umeng_message_proguard_W_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='X']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.umeng.message.proguard.W']]"
		[Register ("a", "(Lcom/umeng/message/proguard/W;)V", "GetA_Lcom_umeng_message_proguard_W_Handler")]
		public virtual void A (global::Com.Umeng.Message.Proguard.W p0)
		{
			if (id_a_Lcom_umeng_message_proguard_W_ == IntPtr.Zero)
				id_a_Lcom_umeng_message_proguard_W_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/umeng/message/proguard/W;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_umeng_message_proguard_W_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Lcom/umeng/message/proguard/W;)V"), new JValue (p0));
		}

	}
}
