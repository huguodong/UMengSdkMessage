using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='M']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/M", DoNotGenerateAcw=true)]
	public partial class M : global::Java.Lang.Object, global::Com.Umeng.Message.Proguard.IK {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/M", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (M); }
		}

		protected M (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_umeng_message_proguard_N_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='M']/constructor[@name='M' and count(parameter)=1 and parameter[1][@type='com.umeng.message.proguard.N']]"
		[Register (".ctor", "(Lcom/umeng/message/proguard/N;)V", "")]
		public M (global::Com.Umeng.Message.Proguard.N p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (M)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/umeng/message/proguard/N;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/umeng/message/proguard/N;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_umeng_message_proguard_N_ == IntPtr.Zero)
				id_ctor_Lcom_umeng_message_proguard_N_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/message/proguard/N;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_message_proguard_N_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_umeng_message_proguard_N_, new JValue (p0));
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
			global::Com.Umeng.Message.Proguard.M __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.M> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='M']/method[@name='a' and count(parameter)=0]"
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

	}
}
