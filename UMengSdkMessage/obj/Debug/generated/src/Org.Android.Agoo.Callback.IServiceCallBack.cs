using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IServiceCallBack']"
	[Register ("org/android/agoo/callback/IServiceCallBack", "", "Org.Android.Agoo.Callback.IServiceCallBackInvoker")]
	public partial interface IServiceCallBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IServiceCallBack']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Org.Android.Agoo.Callback.IServiceCallBackInvoker, UMengSdkMessage")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("org/android/agoo/callback/IServiceCallBack", DoNotGenerateAcw=true)]
	internal class IServiceCallBackInvoker : global::Java.Lang.Object, IServiceCallBack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/callback/IServiceCallBack");
		IntPtr class_ref;

		public static IServiceCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IServiceCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.callback.IServiceCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IServiceCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IServiceCallBackInvoker); }
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Callback.IServiceCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IServiceCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (Handle, id_stop);
		}

	}

}
