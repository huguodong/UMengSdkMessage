using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='T']"
	[Register ("com/umeng/message/proguard/T", "", "Com.Umeng.Message.Proguard.ITInvoker")]
	public partial interface IT : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='T']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("a", "(ILjava/lang/Object;)V", "GetA_ILjava_lang_Object_Handler:Com.Umeng.Message.Proguard.ITInvoker, UMengSdkMessage")]
		void A (int p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/umeng/message/proguard/T", DoNotGenerateAcw=true)]
	internal class ITInvoker : global::Java.Lang.Object, IT {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/message/proguard/T");
		IntPtr class_ref;

		public static IT GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IT> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.message.proguard.T"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ITInvoker); }
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
			global::Com.Umeng.Message.Proguard.IT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_a_ILjava_lang_Object_;
		public void A (int p0, global::Java.Lang.Object p1)
		{
			if (id_a_ILjava_lang_Object_ == IntPtr.Zero)
				id_a_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(ILjava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_a_ILjava_lang_Object_, new JValue (p0), new JValue (p1));
		}

	}

}
