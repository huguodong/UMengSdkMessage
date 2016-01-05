using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.protobuf']/interface[@name='RpcController']"
	[Register ("com/google/protobuf/RpcController", "", "Com.Google.Protobuf.IRpcControllerInvoker")]
	public partial interface IRpcController : IJavaObject {

		bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='RpcController']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler:Com.Google.Protobuf.IRpcControllerInvoker, UMengSdkMessage")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='RpcController']/method[@name='errorText' and count(parameter)=0]"
		[Register ("errorText", "()Ljava/lang/String;", "GetErrorTextHandler:Com.Google.Protobuf.IRpcControllerInvoker, UMengSdkMessage")]
		string ErrorText ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='RpcController']/method[@name='failed' and count(parameter)=0]"
		[Register ("failed", "()Z", "GetFailedHandler:Com.Google.Protobuf.IRpcControllerInvoker, UMengSdkMessage")]
		bool Failed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='RpcController']/method[@name='notifyOnCancel' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.RpcCallback']]"
		[Register ("notifyOnCancel", "(Lcom/google/protobuf/RpcCallback;)V", "GetNotifyOnCancel_Lcom_google_protobuf_RpcCallback_Handler:Com.Google.Protobuf.IRpcControllerInvoker, UMengSdkMessage")]
		void NotifyOnCancel (global::Com.Google.Protobuf.IRpcCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='RpcController']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Google.Protobuf.IRpcControllerInvoker, UMengSdkMessage")]
		void Reset ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='RpcController']/method[@name='setFailed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFailed", "(Ljava/lang/String;)V", "GetSetFailed_Ljava_lang_String_Handler:Com.Google.Protobuf.IRpcControllerInvoker, UMengSdkMessage")]
		void SetFailed (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='RpcController']/method[@name='startCancel' and count(parameter)=0]"
		[Register ("startCancel", "()V", "GetStartCancelHandler:Com.Google.Protobuf.IRpcControllerInvoker, UMengSdkMessage")]
		void StartCancel ();

	}

	[global::Android.Runtime.Register ("com/google/protobuf/RpcController", DoNotGenerateAcw=true)]
	internal class IRpcControllerInvoker : global::Java.Lang.Object, IRpcController {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/protobuf/RpcController");
		IntPtr class_ref;

		public static IRpcController GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRpcController> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.protobuf.RpcController"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRpcControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRpcControllerInvoker); }
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.IRpcController __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IRpcController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		IntPtr id_isCanceled;
		public bool IsCanceled {
			get {
				if (id_isCanceled == IntPtr.Zero)
					id_isCanceled = JNIEnv.GetMethodID (class_ref, "isCanceled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isCanceled);
			}
		}

		static Delegate cb_errorText;
#pragma warning disable 0169
		static Delegate GetErrorTextHandler ()
		{
			if (cb_errorText == null)
				cb_errorText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ErrorText);
			return cb_errorText;
		}

		static IntPtr n_ErrorText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.IRpcController __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IRpcController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorText ());
		}
#pragma warning restore 0169

		IntPtr id_errorText;
		public string ErrorText ()
		{
			if (id_errorText == IntPtr.Zero)
				id_errorText = JNIEnv.GetMethodID (class_ref, "errorText", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_errorText), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_failed;
#pragma warning disable 0169
		static Delegate GetFailedHandler ()
		{
			if (cb_failed == null)
				cb_failed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Failed);
			return cb_failed;
		}

		static bool n_Failed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.IRpcController __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IRpcController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Failed ();
		}
#pragma warning restore 0169

		IntPtr id_failed;
		public bool Failed ()
		{
			if (id_failed == IntPtr.Zero)
				id_failed = JNIEnv.GetMethodID (class_ref, "failed", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_failed);
		}

		static Delegate cb_notifyOnCancel_Lcom_google_protobuf_RpcCallback_;
#pragma warning disable 0169
		static Delegate GetNotifyOnCancel_Lcom_google_protobuf_RpcCallback_Handler ()
		{
			if (cb_notifyOnCancel_Lcom_google_protobuf_RpcCallback_ == null)
				cb_notifyOnCancel_Lcom_google_protobuf_RpcCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyOnCancel_Lcom_google_protobuf_RpcCallback_);
			return cb_notifyOnCancel_Lcom_google_protobuf_RpcCallback_;
		}

		static void n_NotifyOnCancel_Lcom_google_protobuf_RpcCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Protobuf.IRpcController __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IRpcController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.IRpcCallback p0 = (global::Com.Google.Protobuf.IRpcCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IRpcCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyOnCancel (p0);
		}
#pragma warning restore 0169

		IntPtr id_notifyOnCancel_Lcom_google_protobuf_RpcCallback_;
		public void NotifyOnCancel (global::Com.Google.Protobuf.IRpcCallback p0)
		{
			if (id_notifyOnCancel_Lcom_google_protobuf_RpcCallback_ == IntPtr.Zero)
				id_notifyOnCancel_Lcom_google_protobuf_RpcCallback_ = JNIEnv.GetMethodID (class_ref, "notifyOnCancel", "(Lcom/google/protobuf/RpcCallback;)V");
			JNIEnv.CallVoidMethod (Handle, id_notifyOnCancel_Lcom_google_protobuf_RpcCallback_, new JValue (p0));
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.IRpcController __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IRpcController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (Handle, id_reset);
		}

		static Delegate cb_setFailed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFailed_Ljava_lang_String_Handler ()
		{
			if (cb_setFailed_Ljava_lang_String_ == null)
				cb_setFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFailed_Ljava_lang_String_);
			return cb_setFailed_Ljava_lang_String_;
		}

		static void n_SetFailed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Protobuf.IRpcController __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IRpcController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_setFailed_Ljava_lang_String_;
		public void SetFailed (string p0)
		{
			if (id_setFailed_Ljava_lang_String_ == IntPtr.Zero)
				id_setFailed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFailed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_setFailed_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_startCancel;
#pragma warning disable 0169
		static Delegate GetStartCancelHandler ()
		{
			if (cb_startCancel == null)
				cb_startCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartCancel);
			return cb_startCancel;
		}

		static void n_StartCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.IRpcController __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IRpcController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartCancel ();
		}
#pragma warning restore 0169

		IntPtr id_startCancel;
		public void StartCancel ()
		{
			if (id_startCancel == IntPtr.Zero)
				id_startCancel = JNIEnv.GetMethodID (class_ref, "startCancel", "()V");
			JNIEnv.CallVoidMethod (Handle, id_startCancel);
		}

	}

}
