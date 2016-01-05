using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo']/interface[@name='IVoteService']"
	[Register ("org/android/agoo/IVoteService", "", "Org.Android.Agoo.IVoteServiceInvoker")]
	public partial interface IVoteService : global::Org.Android.Agoo.IService {

	}

	[global::Android.Runtime.Register ("org/android/agoo/IVoteService", DoNotGenerateAcw=true)]
	internal class IVoteServiceInvoker : global::Java.Lang.Object, IVoteService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/IVoteService");
		IntPtr class_ref;

		public static IVoteService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVoteService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.IVoteService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVoteServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IVoteServiceInvoker); }
		}

		static Delegate cb_bind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetBind_Landroid_content_Intent_Handler ()
		{
			if (cb_bind_Landroid_content_Intent_ == null)
				cb_bind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Bind_Landroid_content_Intent_);
			return cb_bind_Landroid_content_Intent_;
		}

		static IntPtr n_Bind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.IVoteService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IVoteService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Bind (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_bind_Landroid_content_Intent_;
		public global::Android.OS.IBinder Bind (global::Android.Content.Intent p0)
		{
			if (id_bind_Landroid_content_Intent_ == IntPtr.Zero)
				id_bind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "bind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::Android.OS.IBinder __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (Handle, id_bind_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_;
#pragma warning disable 0169
		static Delegate GetCreate_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_Handler ()
		{
			if (cb_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_ == null)
				cb_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_);
			return cb_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_;
		}

		static void n_Create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.IVoteService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IVoteService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Callback.IServiceCallBack p1 = (global::Org.Android.Agoo.Callback.IServiceCallBack)global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IServiceCallBack> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Create (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_;
		public void Create (global::Android.Content.Context p0, global::Org.Android.Agoo.Callback.IServiceCallBack p1)
		{
			if (id_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_ == IntPtr.Zero)
				id_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/content/Context;Lorg/android/agoo/callback/IServiceCallBack;)V");
			JNIEnv.CallVoidMethod (Handle, id_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_destroy_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDestroy_Landroid_content_Context_Handler ()
		{
			if (cb_destroy_Landroid_content_Context_ == null)
				cb_destroy_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Destroy_Landroid_content_Context_);
			return cb_destroy_Landroid_content_Context_;
		}

		static void n_Destroy_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.IVoteService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IVoteService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Destroy (p0);
		}
#pragma warning restore 0169

		IntPtr id_destroy_Landroid_content_Context_;
		public void Destroy (global::Android.Content.Context p0)
		{
			if (id_destroy_Landroid_content_Context_ == IntPtr.Zero)
				id_destroy_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "destroy", "(Landroid/content/Context;)V");
			JNIEnv.CallVoidMethod (Handle, id_destroy_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_startCommand_Landroid_content_Intent_II;
#pragma warning disable 0169
		static Delegate GetStartCommand_Landroid_content_Intent_IIHandler ()
		{
			if (cb_startCommand_Landroid_content_Intent_II == null)
				cb_startCommand_Landroid_content_Intent_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_StartCommand_Landroid_content_Intent_II);
			return cb_startCommand_Landroid_content_Intent_II;
		}

		static int n_StartCommand_Landroid_content_Intent_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Org.Android.Agoo.IVoteService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IVoteService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartCommand (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startCommand_Landroid_content_Intent_II;
		public int StartCommand (global::Android.Content.Intent p0, int p1, int p2)
		{
			if (id_startCommand_Landroid_content_Intent_II == IntPtr.Zero)
				id_startCommand_Landroid_content_Intent_II = JNIEnv.GetMethodID (class_ref, "startCommand", "(Landroid/content/Intent;II)I");
			int __ret = JNIEnv.CallIntMethod (Handle, id_startCommand_Landroid_content_Intent_II, new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static Delegate cb_unbind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetUnbind_Landroid_content_Intent_Handler ()
		{
			if (cb_unbind_Landroid_content_Intent_ == null)
				cb_unbind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Unbind_Landroid_content_Intent_);
			return cb_unbind_Landroid_content_Intent_;
		}

		static bool n_Unbind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.IVoteService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IVoteService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Unbind (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unbind_Landroid_content_Intent_;
		public bool Unbind (global::Android.Content.Intent p0)
		{
			if (id_unbind_Landroid_content_Intent_ == IntPtr.Zero)
				id_unbind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "unbind", "(Landroid/content/Intent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_unbind_Landroid_content_Intent_, new JValue (p0));
			return __ret;
		}

	}

}
