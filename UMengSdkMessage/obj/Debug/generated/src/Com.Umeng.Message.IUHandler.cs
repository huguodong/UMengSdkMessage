using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.message']/interface[@name='UHandler']"
	[Register ("com/umeng/message/UHandler", "", "Com.Umeng.Message.IUHandlerInvoker")]
	public partial interface IUHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/interface[@name='UHandler']/method[@name='handleMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.entity.UMessage']]"
		[Register ("handleMessage", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V", "GetHandleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler:Com.Umeng.Message.IUHandlerInvoker, UMengSdkMessage")]
		void HandleMessage (global::Android.Content.Context p0, global::Com.Umeng.Message.Entity.UMessage p1);

	}

	[global::Android.Runtime.Register ("com/umeng/message/UHandler", DoNotGenerateAcw=true)]
	internal class IUHandlerInvoker : global::Java.Lang.Object, IUHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/message/UHandler");
		IntPtr class_ref;

		public static IUHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.message.UHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IUHandlerInvoker); }
		}

		static Delegate cb_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler ()
		{
			if (cb_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == null)
				cb_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_);
			return cb_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		}

		static void n_HandleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.IUHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleMessage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		public void HandleMessage (global::Android.Content.Context p0, global::Com.Umeng.Message.Entity.UMessage p1)
		{
			if (id_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == IntPtr.Zero)
				id_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V");
			JNIEnv.CallVoidMethod (Handle, id_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_, new JValue (p0), new JValue (p1));
		}

	}

}
