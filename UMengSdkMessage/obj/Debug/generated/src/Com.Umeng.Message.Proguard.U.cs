using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='U']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/U", DoNotGenerateAcw=true)]
	public partial class U : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/U", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (U); }
		}

		protected U (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='U']/constructor[@name='U' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public U () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (U)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='U']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/umeng/message/proguard/U;", "")]
		public static global::Com.Umeng.Message.Proguard.U A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Lcom/umeng/message/proguard/U;");
			return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.U> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_a_Lcom_umeng_message_proguard_T_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_umeng_message_proguard_T_Handler ()
		{
			if (cb_a_Lcom_umeng_message_proguard_T_ == null)
				cb_a_Lcom_umeng_message_proguard_T_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_umeng_message_proguard_T_);
			return cb_a_Lcom_umeng_message_proguard_T_;
		}

		static void n_A_Lcom_umeng_message_proguard_T_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.U __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.U> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Proguard.IT p0 = (global::Com.Umeng.Message.Proguard.IT)global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IT> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Lcom_umeng_message_proguard_T_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='U']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.umeng.message.proguard.T']]"
		[Register ("a", "(Lcom/umeng/message/proguard/T;)V", "GetA_Lcom_umeng_message_proguard_T_Handler")]
		public virtual void A (global::Com.Umeng.Message.Proguard.IT p0)
		{
			if (id_a_Lcom_umeng_message_proguard_T_ == IntPtr.Zero)
				id_a_Lcom_umeng_message_proguard_T_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/umeng/message/proguard/T;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_umeng_message_proguard_T_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Lcom/umeng/message/proguard/T;)V"), new JValue (p0));
		}

		static Delegate cb_a_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetA_ILjava_lang_Object_Handler ()
		{
			if (cb_a_ILjava_lang_Object_ == null)
				cb_a_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_A_ILjava_lang_Object_);
			return cb_a_ILjava_lang_Object_;
		}

		static void n_A_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.U __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.U> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='U']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("a", "(ILjava/lang/Object;)V", "GetA_ILjava_lang_Object_Handler")]
		public virtual void A (int p0, global::Java.Lang.Object p1)
		{
			if (id_a_ILjava_lang_Object_ == IntPtr.Zero)
				id_a_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(ILjava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_ILjava_lang_Object_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(ILjava/lang/Object;)V"), new JValue (p0), new JValue (p1));
		}

	}
}
