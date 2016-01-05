using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo']/interface[@name='IControlService']"
	[Register ("org/android/agoo/IControlService", "", "Org.Android.Agoo.IControlServiceInvoker")]
	public partial interface IControlService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo']/interface[@name='IControlService']/method[@name='onHandleIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='org.android.agoo.callback.IControlCallBack']]"
		[Register ("onHandleIntent", "(Landroid/content/Context;Landroid/content/Intent;Lorg/android/agoo/callback/IControlCallBack;)V", "GetOnHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_Handler:Org.Android.Agoo.IControlServiceInvoker, UMengSdkMessage")]
		void OnHandleIntent (global::Android.Content.Context p0, global::Android.Content.Intent p1, global::Org.Android.Agoo.Callback.IControlCallBack p2);

	}

	[global::Android.Runtime.Register ("org/android/agoo/IControlService", DoNotGenerateAcw=true)]
	internal class IControlServiceInvoker : global::Java.Lang.Object, IControlService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/IControlService");
		IntPtr class_ref;

		public static IControlService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IControlService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.IControlService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IControlServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IControlServiceInvoker); }
		}

		static Delegate cb_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_;
#pragma warning disable 0169
		static Delegate GetOnHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_Handler ()
		{
			if (cb_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_ == null)
				cb_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_);
			return cb_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_;
		}

		static void n_OnHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Android.Agoo.IControlService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IControlService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Callback.IControlCallBack p2 = (global::Org.Android.Agoo.Callback.IControlCallBack)global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleIntent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_;
		public void OnHandleIntent (global::Android.Content.Context p0, global::Android.Content.Intent p1, global::Org.Android.Agoo.Callback.IControlCallBack p2)
		{
			if (id_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_ == IntPtr.Zero)
				id_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_ = JNIEnv.GetMethodID (class_ref, "onHandleIntent", "(Landroid/content/Context;Landroid/content/Intent;Lorg/android/agoo/callback/IControlCallBack;)V");
			JNIEnv.CallVoidMethod (Handle, id_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

}
