using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']"
	[global::Android.Runtime.Register ("org/android/agoo/impl/PushService", DoNotGenerateAcw=true)]
	public partial class PushService : global::Java.Lang.Object, global::Android.OS.Handler.ICallback, global::Com.Umeng.Message.Proguard.IAO, global::Org.Android.Agoo.IPushService {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/impl/PushService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushService); }
		}

		protected PushService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/constructor[@name='PushService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PushService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PushService)) {
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
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		protected virtual void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()V"));
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		protected virtual void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_b);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()V"));
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
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Bind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_bind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='bind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("bind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetBind_Landroid_content_Intent_Handler")]
		public virtual global::Android.OS.IBinder Bind (global::Android.Content.Intent p0)
		{
			if (id_bind_Landroid_content_Intent_ == IntPtr.Zero)
				id_bind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "bind", "(Landroid/content/Intent;)Landroid/os/IBinder;");

			global::Android.OS.IBinder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_bind_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bind", "(Landroid/content/Intent;)Landroid/os/IBinder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		protected void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_c);
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
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Callback.IServiceCallBack p1 = (global::Org.Android.Agoo.Callback.IServiceCallBack)global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IServiceCallBack> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Create (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='create' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.callback.IServiceCallBack']]"
		[Register ("create", "(Landroid/content/Context;Lorg/android/agoo/callback/IServiceCallBack;)V", "GetCreate_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_Handler")]
		public virtual void Create (global::Android.Content.Context p0, global::Org.Android.Agoo.Callback.IServiceCallBack p1)
		{
			if (id_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_ == IntPtr.Zero)
				id_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/content/Context;Lorg/android/agoo/callback/IServiceCallBack;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_create_Landroid_content_Context_Lorg_android_agoo_callback_IServiceCallBack_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Landroid/content/Context;Lorg/android/agoo/callback/IServiceCallBack;)V"), new JValue (p0), new JValue (p1));
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
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Destroy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_destroy_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='destroy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("destroy", "(Landroid/content/Context;)V", "GetDestroy_Landroid_content_Context_Handler")]
		public virtual void Destroy (global::Android.Content.Context p0)
		{
			if (id_destroy_Landroid_content_Context_ == IntPtr.Zero)
				id_destroy_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "destroy", "(Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_destroy_Landroid_content_Context_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "(Landroid/content/Context;)V"), new JValue (p0));
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual bool HandleMessage (global::Android.OS.Message p0)
		{
			if (id_handleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_handleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/os/Message;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_handleMessage_Landroid_os_Message_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMessage", "(Landroid/os/Message;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_hasComeFromCock_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetHasComeFromCock_Landroid_content_Intent_Handler ()
		{
			if (cb_hasComeFromCock_Landroid_content_Intent_ == null)
				cb_hasComeFromCock_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasComeFromCock_Landroid_content_Intent_);
			return cb_hasComeFromCock_Landroid_content_Intent_;
		}

		static bool n_HasComeFromCock_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasComeFromCock (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasComeFromCock_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='hasComeFromCock' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("hasComeFromCock", "(Landroid/content/Intent;)Z", "GetHasComeFromCock_Landroid_content_Intent_Handler")]
		public virtual bool HasComeFromCock (global::Android.Content.Intent p0)
		{
			if (id_hasComeFromCock_Landroid_content_Intent_ == IntPtr.Zero)
				id_hasComeFromCock_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "hasComeFromCock", "(Landroid/content/Intent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_hasComeFromCock_Landroid_content_Intent_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasComeFromCock", "(Landroid/content/Intent;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_onHandleCommand_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnHandleCommand_Ljava_lang_String_Handler ()
		{
			if (cb_onHandleCommand_Ljava_lang_String_ == null)
				cb_onHandleCommand_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHandleCommand_Ljava_lang_String_);
			return cb_onHandleCommand_Ljava_lang_String_;
		}

		static void n_OnHandleCommand_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleCommand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onHandleCommand_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='onHandleCommand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onHandleCommand", "(Ljava/lang/String;)V", "GetOnHandleCommand_Ljava_lang_String_Handler")]
		public virtual void OnHandleCommand (string p0)
		{
			if (id_onHandleCommand_Ljava_lang_String_ == IntPtr.Zero)
				id_onHandleCommand_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onHandleCommand", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onHandleCommand_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHandleCommand", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onHandleError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnHandleError_Ljava_lang_String_Handler ()
		{
			if (cb_onHandleError_Ljava_lang_String_ == null)
				cb_onHandleError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHandleError_Ljava_lang_String_);
			return cb_onHandleError_Ljava_lang_String_;
		}

		static void n_OnHandleError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onHandleError_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='onHandleError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onHandleError", "(Ljava/lang/String;)V", "GetOnHandleError_Ljava_lang_String_Handler")]
		public virtual void OnHandleError (string p0)
		{
			if (id_onHandleError_Ljava_lang_String_ == IntPtr.Zero)
				id_onHandleError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onHandleError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onHandleError_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHandleError", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnHandleMessage_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnHandleMessage_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static void n_OnHandleMessage_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='onHandleMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onHandleMessage", "(Ljava/lang/String;Landroid/os/Bundle;)V", "GetOnHandleMessage_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public virtual void OnHandleMessage (string p0, global::Android.OS.Bundle p1)
		{
			if (id_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onHandleMessage", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHandleMessage", "(Ljava/lang/String;Landroid/os/Bundle;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartCommand (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startCommand_Landroid_content_Intent_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='startCommand' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("startCommand", "(Landroid/content/Intent;II)I", "GetStartCommand_Landroid_content_Intent_IIHandler")]
		public virtual int StartCommand (global::Android.Content.Intent p0, int p1, int p2)
		{
			if (id_startCommand_Landroid_content_Intent_II == IntPtr.Zero)
				id_startCommand_Landroid_content_Intent_II = JNIEnv.GetMethodID (class_ref, "startCommand", "(Landroid/content/Intent;II)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_startCommand_Landroid_content_Intent_II, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startCommand", "(Landroid/content/Intent;II)I"), new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Org.Android.Agoo.Impl.PushService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Unbind (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unbind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='PushService']/method[@name='unbind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("unbind", "(Landroid/content/Intent;)Z", "GetUnbind_Landroid_content_Intent_Handler")]
		public virtual bool Unbind (global::Android.Content.Intent p0)
		{
			if (id_unbind_Landroid_content_Intent_ == IntPtr.Zero)
				id_unbind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "unbind", "(Landroid/content/Intent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_unbind_Landroid_content_Intent_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unbind", "(Landroid/content/Intent;)Z"), new JValue (p0));
			return __ret;
		}

	}
}
