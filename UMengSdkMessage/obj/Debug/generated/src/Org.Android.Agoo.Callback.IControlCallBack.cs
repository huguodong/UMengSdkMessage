using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']"
	[Register ("org/android/agoo/callback/IControlCallBack", "", "Org.Android.Agoo.Callback.IControlCallBackInvoker")]
	public partial interface IControlCallBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callAgooElectionReceiver' and count(parameter)=0]"
		[Register ("callAgooElectionReceiver", "()Ljava/lang/Class;", "GetCallAgooElectionReceiverHandler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		global::Java.Lang.Class CallAgooElectionReceiver ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callAgooMessageReceiver' and count(parameter)=0]"
		[Register ("callAgooMessageReceiver", "()Ljava/lang/Class;", "GetCallAgooMessageReceiverHandler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		global::Java.Lang.Class CallAgooMessageReceiver ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callAgooRegistrationReceiver' and count(parameter)=0]"
		[Register ("callAgooRegistrationReceiver", "()Ljava/lang/Class;", "GetCallAgooRegistrationReceiverHandler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		global::Java.Lang.Class CallAgooRegistrationReceiver ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callAgooService' and count(parameter)=0]"
		[Register ("callAgooService", "()Ljava/lang/Class;", "GetCallAgooServiceHandler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		global::Java.Lang.Class CallAgooService ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callAgooSystemReceiver' and count(parameter)=0]"
		[Register ("callAgooSystemReceiver", "()Ljava/lang/Class;", "GetCallAgooSystemReceiverHandler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		global::Java.Lang.Class CallAgooSystemReceiver ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callDeletedMessages' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("callDeletedMessages", "(Landroid/content/Context;I)V", "GetCallDeletedMessages_Landroid_content_Context_IHandler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		void CallDeletedMessages (global::Android.Content.Context p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callError' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("callError", "(Landroid/content/Context;Ljava/lang/String;)V", "GetCallError_Landroid_content_Context_Ljava_lang_String_Handler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		void CallError (global::Android.Content.Context p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("callMessage", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetCallMessage_Landroid_content_Context_Landroid_content_Intent_Handler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		void CallMessage (global::Android.Content.Context p0, global::Android.Content.Intent p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callRecoverableError' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("callRecoverableError", "(Landroid/content/Context;Ljava/lang/String;)Z", "GetCallRecoverableError_Landroid_content_Context_Ljava_lang_String_Handler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		bool CallRecoverableError (global::Android.Content.Context p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callRegistered' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("callRegistered", "(Landroid/content/Context;Ljava/lang/String;)V", "GetCallRegistered_Landroid_content_Context_Ljava_lang_String_Handler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		void CallRegistered (global::Android.Content.Context p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callShouldProcessMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("callShouldProcessMessage", "(Landroid/content/Context;Landroid/content/Intent;)Z", "GetCallShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_Handler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		bool CallShouldProcessMessage (global::Android.Content.Context p0, global::Android.Content.Intent p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callUnregistered' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("callUnregistered", "(Landroid/content/Context;Ljava/lang/String;)V", "GetCallUnregistered_Landroid_content_Context_Ljava_lang_String_Handler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		void CallUnregistered (global::Android.Content.Context p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callUserCommand' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("callUserCommand", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetCallUserCommand_Landroid_content_Context_Landroid_content_Intent_Handler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		void CallUserCommand (global::Android.Content.Context p0, global::Android.Content.Intent p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.callback']/interface[@name='IControlCallBack']/method[@name='callUserHandleIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("callUserHandleIntent", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetCallUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_Handler:Org.Android.Agoo.Callback.IControlCallBackInvoker, UMengSdkMessage")]
		void CallUserHandleIntent (global::Android.Content.Context p0, global::Android.Content.Intent p1);

	}

	[global::Android.Runtime.Register ("org/android/agoo/callback/IControlCallBack", DoNotGenerateAcw=true)]
	internal class IControlCallBackInvoker : global::Java.Lang.Object, IControlCallBack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/callback/IControlCallBack");
		IntPtr class_ref;

		public static IControlCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IControlCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.callback.IControlCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IControlCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IControlCallBackInvoker); }
		}

		static Delegate cb_callAgooElectionReceiver;
#pragma warning disable 0169
		static Delegate GetCallAgooElectionReceiverHandler ()
		{
			if (cb_callAgooElectionReceiver == null)
				cb_callAgooElectionReceiver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CallAgooElectionReceiver);
			return cb_callAgooElectionReceiver;
		}

		static IntPtr n_CallAgooElectionReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CallAgooElectionReceiver ());
		}
#pragma warning restore 0169

		IntPtr id_callAgooElectionReceiver;
		public global::Java.Lang.Class CallAgooElectionReceiver ()
		{
			if (id_callAgooElectionReceiver == IntPtr.Zero)
				id_callAgooElectionReceiver = JNIEnv.GetMethodID (class_ref, "callAgooElectionReceiver", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (Handle, id_callAgooElectionReceiver), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_callAgooMessageReceiver;
#pragma warning disable 0169
		static Delegate GetCallAgooMessageReceiverHandler ()
		{
			if (cb_callAgooMessageReceiver == null)
				cb_callAgooMessageReceiver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CallAgooMessageReceiver);
			return cb_callAgooMessageReceiver;
		}

		static IntPtr n_CallAgooMessageReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CallAgooMessageReceiver ());
		}
#pragma warning restore 0169

		IntPtr id_callAgooMessageReceiver;
		public global::Java.Lang.Class CallAgooMessageReceiver ()
		{
			if (id_callAgooMessageReceiver == IntPtr.Zero)
				id_callAgooMessageReceiver = JNIEnv.GetMethodID (class_ref, "callAgooMessageReceiver", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (Handle, id_callAgooMessageReceiver), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_callAgooRegistrationReceiver;
#pragma warning disable 0169
		static Delegate GetCallAgooRegistrationReceiverHandler ()
		{
			if (cb_callAgooRegistrationReceiver == null)
				cb_callAgooRegistrationReceiver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CallAgooRegistrationReceiver);
			return cb_callAgooRegistrationReceiver;
		}

		static IntPtr n_CallAgooRegistrationReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CallAgooRegistrationReceiver ());
		}
#pragma warning restore 0169

		IntPtr id_callAgooRegistrationReceiver;
		public global::Java.Lang.Class CallAgooRegistrationReceiver ()
		{
			if (id_callAgooRegistrationReceiver == IntPtr.Zero)
				id_callAgooRegistrationReceiver = JNIEnv.GetMethodID (class_ref, "callAgooRegistrationReceiver", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (Handle, id_callAgooRegistrationReceiver), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_callAgooService;
#pragma warning disable 0169
		static Delegate GetCallAgooServiceHandler ()
		{
			if (cb_callAgooService == null)
				cb_callAgooService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CallAgooService);
			return cb_callAgooService;
		}

		static IntPtr n_CallAgooService (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CallAgooService ());
		}
#pragma warning restore 0169

		IntPtr id_callAgooService;
		public global::Java.Lang.Class CallAgooService ()
		{
			if (id_callAgooService == IntPtr.Zero)
				id_callAgooService = JNIEnv.GetMethodID (class_ref, "callAgooService", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (Handle, id_callAgooService), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_callAgooSystemReceiver;
#pragma warning disable 0169
		static Delegate GetCallAgooSystemReceiverHandler ()
		{
			if (cb_callAgooSystemReceiver == null)
				cb_callAgooSystemReceiver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CallAgooSystemReceiver);
			return cb_callAgooSystemReceiver;
		}

		static IntPtr n_CallAgooSystemReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CallAgooSystemReceiver ());
		}
#pragma warning restore 0169

		IntPtr id_callAgooSystemReceiver;
		public global::Java.Lang.Class CallAgooSystemReceiver ()
		{
			if (id_callAgooSystemReceiver == IntPtr.Zero)
				id_callAgooSystemReceiver = JNIEnv.GetMethodID (class_ref, "callAgooSystemReceiver", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (Handle, id_callAgooSystemReceiver), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_callDeletedMessages_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetCallDeletedMessages_Landroid_content_Context_IHandler ()
		{
			if (cb_callDeletedMessages_Landroid_content_Context_I == null)
				cb_callDeletedMessages_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_CallDeletedMessages_Landroid_content_Context_I);
			return cb_callDeletedMessages_Landroid_content_Context_I;
		}

		static void n_CallDeletedMessages_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CallDeletedMessages (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_callDeletedMessages_Landroid_content_Context_I;
		public void CallDeletedMessages (global::Android.Content.Context p0, int p1)
		{
			if (id_callDeletedMessages_Landroid_content_Context_I == IntPtr.Zero)
				id_callDeletedMessages_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "callDeletedMessages", "(Landroid/content/Context;I)V");
			JNIEnv.CallVoidMethod (Handle, id_callDeletedMessages_Landroid_content_Context_I, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_callError_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCallError_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_callError_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_callError_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CallError_Landroid_content_Context_Ljava_lang_String_);
			return cb_callError_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_CallError_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CallError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_callError_Landroid_content_Context_Ljava_lang_String_;
		public void CallError (global::Android.Content.Context p0, string p1)
		{
			if (id_callError_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_callError_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "callError", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_callError_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_callMessage_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetCallMessage_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_callMessage_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_callMessage_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CallMessage_Landroid_content_Context_Landroid_content_Intent_);
			return cb_callMessage_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_CallMessage_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CallMessage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_callMessage_Landroid_content_Context_Landroid_content_Intent_;
		public void CallMessage (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_callMessage_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_callMessage_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "callMessage", "(Landroid/content/Context;Landroid/content/Intent;)V");
			JNIEnv.CallVoidMethod (Handle, id_callMessage_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_callRecoverableError_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCallRecoverableError_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_callRecoverableError_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_callRecoverableError_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CallRecoverableError_Landroid_content_Context_Ljava_lang_String_);
			return cb_callRecoverableError_Landroid_content_Context_Ljava_lang_String_;
		}

		static bool n_CallRecoverableError_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CallRecoverableError (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_callRecoverableError_Landroid_content_Context_Ljava_lang_String_;
		public bool CallRecoverableError (global::Android.Content.Context p0, string p1)
		{
			if (id_callRecoverableError_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_callRecoverableError_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "callRecoverableError", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_callRecoverableError_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_callRegistered_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCallRegistered_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_callRegistered_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_callRegistered_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CallRegistered_Landroid_content_Context_Ljava_lang_String_);
			return cb_callRegistered_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_CallRegistered_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CallRegistered (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_callRegistered_Landroid_content_Context_Ljava_lang_String_;
		public void CallRegistered (global::Android.Content.Context p0, string p1)
		{
			if (id_callRegistered_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_callRegistered_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "callRegistered", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_callRegistered_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_callShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetCallShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_callShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_callShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CallShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_);
			return cb_callShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_;
		}

		static bool n_CallShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CallShouldProcessMessage (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_callShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_;
		public bool CallShouldProcessMessage (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_callShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_callShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "callShouldProcessMessage", "(Landroid/content/Context;Landroid/content/Intent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_callShouldProcessMessage_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_callUnregistered_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCallUnregistered_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_callUnregistered_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_callUnregistered_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CallUnregistered_Landroid_content_Context_Ljava_lang_String_);
			return cb_callUnregistered_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_CallUnregistered_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CallUnregistered (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_callUnregistered_Landroid_content_Context_Ljava_lang_String_;
		public void CallUnregistered (global::Android.Content.Context p0, string p1)
		{
			if (id_callUnregistered_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_callUnregistered_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "callUnregistered", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_callUnregistered_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_callUserCommand_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetCallUserCommand_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_callUserCommand_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_callUserCommand_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CallUserCommand_Landroid_content_Context_Landroid_content_Intent_);
			return cb_callUserCommand_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_CallUserCommand_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CallUserCommand (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_callUserCommand_Landroid_content_Context_Landroid_content_Intent_;
		public void CallUserCommand (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_callUserCommand_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_callUserCommand_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "callUserCommand", "(Landroid/content/Context;Landroid/content/Intent;)V");
			JNIEnv.CallVoidMethod (Handle, id_callUserCommand_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_callUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetCallUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_callUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_callUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CallUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_);
			return cb_callUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_CallUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Callback.IControlCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Callback.IControlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CallUserHandleIntent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_callUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_;
		public void CallUserHandleIntent (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_callUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_callUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "callUserHandleIntent", "(Landroid/content/Context;Landroid/content/Intent;)V");
			JNIEnv.CallVoidMethod (Handle, id_callUserHandleIntent_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
		}

	}

}
