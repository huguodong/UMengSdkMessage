using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.message']/interface[@name='IUmengRegisterCallback']"
	[Register ("com/umeng/message/IUmengRegisterCallback", "", "Com.Umeng.Message.IUmengRegisterCallbackInvoker")]
	public partial interface IUmengRegisterCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/interface[@name='IUmengRegisterCallback']/method[@name='onRegistered' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRegistered", "(Ljava/lang/String;)V", "GetOnRegistered_Ljava_lang_String_Handler:Com.Umeng.Message.IUmengRegisterCallbackInvoker, UMengSdkMessage")]
		void OnRegistered (string p0);

	}

	[global::Android.Runtime.Register ("com/umeng/message/IUmengRegisterCallback", DoNotGenerateAcw=true)]
	internal class IUmengRegisterCallbackInvoker : global::Java.Lang.Object, IUmengRegisterCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/message/IUmengRegisterCallback");
		IntPtr class_ref;

		public static IUmengRegisterCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUmengRegisterCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.message.IUmengRegisterCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUmengRegisterCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IUmengRegisterCallbackInvoker); }
		}

		static Delegate cb_onRegistered_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRegistered_Ljava_lang_String_Handler ()
		{
			if (cb_onRegistered_Ljava_lang_String_ == null)
				cb_onRegistered_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRegistered_Ljava_lang_String_);
			return cb_onRegistered_Ljava_lang_String_;
		}

		static void n_OnRegistered_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.IUmengRegisterCallback __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUmengRegisterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRegistered (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRegistered_Ljava_lang_String_;
		public void OnRegistered (string p0)
		{
			if (id_onRegistered_Ljava_lang_String_ == IntPtr.Zero)
				id_onRegistered_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRegistered", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_onRegistered_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
