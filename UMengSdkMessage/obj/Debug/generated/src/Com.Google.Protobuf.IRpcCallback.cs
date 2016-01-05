using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.protobuf']/interface[@name='RpcCallback']"
	[Register ("com/google/protobuf/RpcCallback", "", "Com.Google.Protobuf.IRpcCallbackInvoker")]
	public partial interface IRpcCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='RpcCallback']/method[@name='run' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("run", "(Ljava/lang/Object;)V", "GetRun_Ljava_lang_Object_Handler:Com.Google.Protobuf.IRpcCallbackInvoker, UMengSdkMessage")]
		void Run (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/google/protobuf/RpcCallback", DoNotGenerateAcw=true)]
	internal class IRpcCallbackInvoker : global::Java.Lang.Object, IRpcCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/protobuf/RpcCallback");
		IntPtr class_ref;

		public static IRpcCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRpcCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.protobuf.RpcCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRpcCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRpcCallbackInvoker); }
		}

		static Delegate cb_run_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRun_Ljava_lang_Object_Handler ()
		{
			if (cb_run_Ljava_lang_Object_ == null)
				cb_run_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Run_Ljava_lang_Object_);
			return cb_run_Ljava_lang_Object_;
		}

		static void n_Run_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Protobuf.IRpcCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IRpcCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Run (p0);
		}
#pragma warning restore 0169

		IntPtr id_run_Ljava_lang_Object_;
		public void Run (global::Java.Lang.Object p0)
		{
			if (id_run_Ljava_lang_Object_ == IntPtr.Zero)
				id_run_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "run", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_run_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
