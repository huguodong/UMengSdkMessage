using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='SingleFieldBuilder']"
	[global::Android.Runtime.Register ("com/google/protobuf/SingleFieldBuilder", DoNotGenerateAcw=true)]
	public partial class SingleFieldBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/SingleFieldBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleFieldBuilder); }
		}

		protected SingleFieldBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBuilder;
#pragma warning disable 0169
		static Delegate GetGetBuilderHandler ()
		{
			if (cb_getBuilder == null)
				cb_getBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuilder);
			return cb_getBuilder;
		}

		static IntPtr n_GetBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.SingleFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Builder);
		}
#pragma warning restore 0169

		static IntPtr id_getBuilder;
		public virtual global::Java.Lang.Object Builder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='SingleFieldBuilder']/method[@name='getBuilder' and count(parameter)=0]"
			[Register ("getBuilder", "()Ljava/lang/Object;", "GetGetBuilderHandler")]
			get {
				if (id_getBuilder == IntPtr.Zero)
					id_getBuilder = JNIEnv.GetMethodID (class_ref, "getBuilder", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getBuilder), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuilder", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.SingleFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual global::Java.Lang.Object Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='SingleFieldBuilder']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lcom/google/protobuf/GeneratedMessage;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Lcom/google/protobuf/GeneratedMessage;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Lcom/google/protobuf/GeneratedMessage;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessageOrBuilder;
#pragma warning disable 0169
		static Delegate GetGetMessageOrBuilderHandler ()
		{
			if (cb_getMessageOrBuilder == null)
				cb_getMessageOrBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageOrBuilder);
			return cb_getMessageOrBuilder;
		}

		static IntPtr n_GetMessageOrBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.SingleFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessageOrBuilder);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageOrBuilder;
		public virtual global::Java.Lang.Object MessageOrBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='SingleFieldBuilder']/method[@name='getMessageOrBuilder' and count(parameter)=0]"
			[Register ("getMessageOrBuilder", "()Lcom/google/protobuf/MessageOrBuilder;", "GetGetMessageOrBuilderHandler")]
			get {
				if (id_getMessageOrBuilder == IntPtr.Zero)
					id_getMessageOrBuilder = JNIEnv.GetMethodID (class_ref, "getMessageOrBuilder", "()Lcom/google/protobuf/MessageOrBuilder;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getMessageOrBuilder), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageOrBuilder", "()Lcom/google/protobuf/MessageOrBuilder;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.SingleFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='SingleFieldBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/google/protobuf/GeneratedMessage;", "GetBuildHandler")]
		public virtual global::Java.Lang.Object Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/protobuf/GeneratedMessage;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/google/protobuf/GeneratedMessage;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static IntPtr n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.SingleFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clear ());
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='SingleFieldBuilder']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Lcom/google/protobuf/SingleFieldBuilder;", "GetClearHandler")]
		public virtual global::Com.Google.Protobuf.SingleFieldBuilder Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/google/protobuf/SingleFieldBuilder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()Lcom/google/protobuf/SingleFieldBuilder;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.SingleFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='SingleFieldBuilder']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispose);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
		}

		static Delegate cb_markDirty;
#pragma warning disable 0169
		static Delegate GetMarkDirtyHandler ()
		{
			if (cb_markDirty == null)
				cb_markDirty = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MarkDirty);
			return cb_markDirty;
		}

		static void n_MarkDirty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.SingleFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkDirty ();
		}
#pragma warning restore 0169

		static IntPtr id_markDirty;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='SingleFieldBuilder']/method[@name='markDirty' and count(parameter)=0]"
		[Register ("markDirty", "()V", "GetMarkDirtyHandler")]
		public virtual void MarkDirty ()
		{
			if (id_markDirty == IntPtr.Zero)
				id_markDirty = JNIEnv.GetMethodID (class_ref, "markDirty", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_markDirty);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markDirty", "()V"));
		}

		static Delegate cb_mergeFrom_Lcom_google_protobuf_GeneratedMessage_;
#pragma warning disable 0169
		static Delegate GetMergeFrom_Lcom_google_protobuf_GeneratedMessage_Handler ()
		{
			if (cb_mergeFrom_Lcom_google_protobuf_GeneratedMessage_ == null)
				cb_mergeFrom_Lcom_google_protobuf_GeneratedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeFrom_Lcom_google_protobuf_GeneratedMessage_);
			return cb_mergeFrom_Lcom_google_protobuf_GeneratedMessage_;
		}

		static IntPtr n_MergeFrom_Lcom_google_protobuf_GeneratedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Protobuf.SingleFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeFrom (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_mergeFrom_Lcom_google_protobuf_GeneratedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='SingleFieldBuilder']/method[@name='mergeFrom' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.GeneratedMessage']]"
		[Register ("mergeFrom", "(Lcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/SingleFieldBuilder;", "GetMergeFrom_Lcom_google_protobuf_GeneratedMessage_Handler")]
		public virtual global::Com.Google.Protobuf.SingleFieldBuilder MergeFrom (global::Java.Lang.Object p0)
		{
			if (id_mergeFrom_Lcom_google_protobuf_GeneratedMessage_ == IntPtr.Zero)
				id_mergeFrom_Lcom_google_protobuf_GeneratedMessage_ = JNIEnv.GetMethodID (class_ref, "mergeFrom", "(Lcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/SingleFieldBuilder;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			global::Com.Google.Protobuf.SingleFieldBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (JNIEnv.CallObjectMethod  (Handle, id_mergeFrom_Lcom_google_protobuf_GeneratedMessage_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mergeFrom", "(Lcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/SingleFieldBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setMessage_Lcom_google_protobuf_GeneratedMessage_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Lcom_google_protobuf_GeneratedMessage_Handler ()
		{
			if (cb_setMessage_Lcom_google_protobuf_GeneratedMessage_ == null)
				cb_setMessage_Lcom_google_protobuf_GeneratedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessage_Lcom_google_protobuf_GeneratedMessage_);
			return cb_setMessage_Lcom_google_protobuf_GeneratedMessage_;
		}

		static IntPtr n_SetMessage_Lcom_google_protobuf_GeneratedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Protobuf.SingleFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMessage_Lcom_google_protobuf_GeneratedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='SingleFieldBuilder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.GeneratedMessage']]"
		[Register ("setMessage", "(Lcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/SingleFieldBuilder;", "GetSetMessage_Lcom_google_protobuf_GeneratedMessage_Handler")]
		public virtual global::Com.Google.Protobuf.SingleFieldBuilder SetMessage (global::Java.Lang.Object p0)
		{
			if (id_setMessage_Lcom_google_protobuf_GeneratedMessage_ == IntPtr.Zero)
				id_setMessage_Lcom_google_protobuf_GeneratedMessage_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Lcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/SingleFieldBuilder;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			global::Com.Google.Protobuf.SingleFieldBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setMessage_Lcom_google_protobuf_GeneratedMessage_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.SingleFieldBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Lcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/SingleFieldBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
