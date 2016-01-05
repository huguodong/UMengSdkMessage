using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']"
	[global::Android.Runtime.Register ("com/google/protobuf/RepeatedFieldBuilder", DoNotGenerateAcw=true)]
	public partial class RepeatedFieldBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/RepeatedFieldBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RepeatedFieldBuilder); }
		}

		protected RepeatedFieldBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBuilderList;
#pragma warning disable 0169
		static Delegate GetGetBuilderListHandler ()
		{
			if (cb_getBuilderList == null)
				cb_getBuilderList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuilderList);
			return cb_getBuilderList;
		}

		static IntPtr n_GetBuilderList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.BuilderList);
		}
#pragma warning restore 0169

		static IntPtr id_getBuilderList;
		public virtual global::System.Collections.IList BuilderList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='getBuilderList' and count(parameter)=0]"
			[Register ("getBuilderList", "()Ljava/util/List;", "GetGetBuilderListHandler")]
			get {
				if (id_getBuilderList == IntPtr.Zero)
					id_getBuilderList = JNIEnv.GetMethodID (class_ref, "getBuilderList", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getBuilderList), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuilderList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public virtual int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isEmpty);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
			}
		}

		static Delegate cb_getMessageList;
#pragma warning disable 0169
		static Delegate GetGetMessageListHandler ()
		{
			if (cb_getMessageList == null)
				cb_getMessageList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageList);
			return cb_getMessageList;
		}

		static IntPtr n_GetMessageList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.MessageList);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageList;
		public virtual global::System.Collections.IList MessageList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='getMessageList' and count(parameter)=0]"
			[Register ("getMessageList", "()Ljava/util/List;", "GetGetMessageListHandler")]
			get {
				if (id_getMessageList == IntPtr.Zero)
					id_getMessageList = JNIEnv.GetMethodID (class_ref, "getMessageList", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMessageList), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessageOrBuilderList;
#pragma warning disable 0169
		static Delegate GetGetMessageOrBuilderListHandler ()
		{
			if (cb_getMessageOrBuilderList == null)
				cb_getMessageOrBuilderList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageOrBuilderList);
			return cb_getMessageOrBuilderList;
		}

		static IntPtr n_GetMessageOrBuilderList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.MessageOrBuilderList);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageOrBuilderList;
		public virtual global::System.Collections.IList MessageOrBuilderList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='getMessageOrBuilderList' and count(parameter)=0]"
			[Register ("getMessageOrBuilderList", "()Ljava/util/List;", "GetGetMessageOrBuilderListHandler")]
			get {
				if (id_getMessageOrBuilderList == IntPtr.Zero)
					id_getMessageOrBuilderList = JNIEnv.GetMethodID (class_ref, "getMessageOrBuilderList", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMessageOrBuilderList), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageOrBuilderList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addAllMessages_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetAddAllMessages_Ljava_lang_Iterable_Handler ()
		{
			if (cb_addAllMessages_Ljava_lang_Iterable_ == null)
				cb_addAllMessages_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAllMessages_Ljava_lang_Iterable_);
			return cb_addAllMessages_Ljava_lang_Iterable_;
		}

		static IntPtr n_AddAllMessages_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p0 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAllMessages (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAllMessages_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='addAllMessages' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("addAllMessages", "(Ljava/lang/Iterable;)Lcom/google/protobuf/RepeatedFieldBuilder;", "GetAddAllMessages_Ljava_lang_Iterable_Handler")]
		public virtual global::Com.Google.Protobuf.RepeatedFieldBuilder AddAllMessages (global::Java.Lang.IIterable p0)
		{
			if (id_addAllMessages_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_addAllMessages_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "addAllMessages", "(Ljava/lang/Iterable;)Lcom/google/protobuf/RepeatedFieldBuilder;");

			global::Com.Google.Protobuf.RepeatedFieldBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (JNIEnv.CallObjectMethod  (Handle, id_addAllMessages_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAllMessages", "(Ljava/lang/Iterable;)Lcom/google/protobuf/RepeatedFieldBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addBuilder_Lcom_google_protobuf_GeneratedMessage_;
#pragma warning disable 0169
		static Delegate GetAddBuilder_Lcom_google_protobuf_GeneratedMessage_Handler ()
		{
			if (cb_addBuilder_Lcom_google_protobuf_GeneratedMessage_ == null)
				cb_addBuilder_Lcom_google_protobuf_GeneratedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddBuilder_Lcom_google_protobuf_GeneratedMessage_);
			return cb_addBuilder_Lcom_google_protobuf_GeneratedMessage_;
		}

		static IntPtr n_AddBuilder_Lcom_google_protobuf_GeneratedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddBuilder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addBuilder_Lcom_google_protobuf_GeneratedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='addBuilder' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.GeneratedMessage']]"
		[Register ("addBuilder", "(Lcom/google/protobuf/GeneratedMessage;)Ljava/lang/Object;", "GetAddBuilder_Lcom_google_protobuf_GeneratedMessage_Handler")]
		public virtual global::Java.Lang.Object AddBuilder (global::Java.Lang.Object p0)
		{
			if (id_addBuilder_Lcom_google_protobuf_GeneratedMessage_ == IntPtr.Zero)
				id_addBuilder_Lcom_google_protobuf_GeneratedMessage_ = JNIEnv.GetMethodID (class_ref, "addBuilder", "(Lcom/google/protobuf/GeneratedMessage;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_addBuilder_Lcom_google_protobuf_GeneratedMessage_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addBuilder", "(Lcom/google/protobuf/GeneratedMessage;)Ljava/lang/Object;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_addBuilder_ILcom_google_protobuf_GeneratedMessage_;
#pragma warning disable 0169
		static Delegate GetAddBuilder_ILcom_google_protobuf_GeneratedMessage_Handler ()
		{
			if (cb_addBuilder_ILcom_google_protobuf_GeneratedMessage_ == null)
				cb_addBuilder_ILcom_google_protobuf_GeneratedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_AddBuilder_ILcom_google_protobuf_GeneratedMessage_);
			return cb_addBuilder_ILcom_google_protobuf_GeneratedMessage_;
		}

		static IntPtr n_AddBuilder_ILcom_google_protobuf_GeneratedMessage_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddBuilder (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addBuilder_ILcom_google_protobuf_GeneratedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='addBuilder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.protobuf.GeneratedMessage']]"
		[Register ("addBuilder", "(ILcom/google/protobuf/GeneratedMessage;)Ljava/lang/Object;", "GetAddBuilder_ILcom_google_protobuf_GeneratedMessage_Handler")]
		public virtual global::Java.Lang.Object AddBuilder (int p0, global::Java.Lang.Object p1)
		{
			if (id_addBuilder_ILcom_google_protobuf_GeneratedMessage_ == IntPtr.Zero)
				id_addBuilder_ILcom_google_protobuf_GeneratedMessage_ = JNIEnv.GetMethodID (class_ref, "addBuilder", "(ILcom/google/protobuf/GeneratedMessage;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_addBuilder_ILcom_google_protobuf_GeneratedMessage_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addBuilder", "(ILcom/google/protobuf/GeneratedMessage;)Ljava/lang/Object;"), new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_addMessage_Lcom_google_protobuf_GeneratedMessage_;
#pragma warning disable 0169
		static Delegate GetAddMessage_Lcom_google_protobuf_GeneratedMessage_Handler ()
		{
			if (cb_addMessage_Lcom_google_protobuf_GeneratedMessage_ == null)
				cb_addMessage_Lcom_google_protobuf_GeneratedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMessage_Lcom_google_protobuf_GeneratedMessage_);
			return cb_addMessage_Lcom_google_protobuf_GeneratedMessage_;
		}

		static IntPtr n_AddMessage_Lcom_google_protobuf_GeneratedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMessage_Lcom_google_protobuf_GeneratedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='addMessage' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.GeneratedMessage']]"
		[Register ("addMessage", "(Lcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/RepeatedFieldBuilder;", "GetAddMessage_Lcom_google_protobuf_GeneratedMessage_Handler")]
		public virtual global::Com.Google.Protobuf.RepeatedFieldBuilder AddMessage (global::Java.Lang.Object p0)
		{
			if (id_addMessage_Lcom_google_protobuf_GeneratedMessage_ == IntPtr.Zero)
				id_addMessage_Lcom_google_protobuf_GeneratedMessage_ = JNIEnv.GetMethodID (class_ref, "addMessage", "(Lcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/RepeatedFieldBuilder;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			global::Com.Google.Protobuf.RepeatedFieldBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (JNIEnv.CallObjectMethod  (Handle, id_addMessage_Lcom_google_protobuf_GeneratedMessage_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMessage", "(Lcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/RepeatedFieldBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_addMessage_ILcom_google_protobuf_GeneratedMessage_;
#pragma warning disable 0169
		static Delegate GetAddMessage_ILcom_google_protobuf_GeneratedMessage_Handler ()
		{
			if (cb_addMessage_ILcom_google_protobuf_GeneratedMessage_ == null)
				cb_addMessage_ILcom_google_protobuf_GeneratedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_AddMessage_ILcom_google_protobuf_GeneratedMessage_);
			return cb_addMessage_ILcom_google_protobuf_GeneratedMessage_;
		}

		static IntPtr n_AddMessage_ILcom_google_protobuf_GeneratedMessage_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMessage_ILcom_google_protobuf_GeneratedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='addMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.protobuf.GeneratedMessage']]"
		[Register ("addMessage", "(ILcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/RepeatedFieldBuilder;", "GetAddMessage_ILcom_google_protobuf_GeneratedMessage_Handler")]
		public virtual global::Com.Google.Protobuf.RepeatedFieldBuilder AddMessage (int p0, global::Java.Lang.Object p1)
		{
			if (id_addMessage_ILcom_google_protobuf_GeneratedMessage_ == IntPtr.Zero)
				id_addMessage_ILcom_google_protobuf_GeneratedMessage_ = JNIEnv.GetMethodID (class_ref, "addMessage", "(ILcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/RepeatedFieldBuilder;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);

			global::Com.Google.Protobuf.RepeatedFieldBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (JNIEnv.CallObjectMethod  (Handle, id_addMessage_ILcom_google_protobuf_GeneratedMessage_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMessage", "(ILcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/RepeatedFieldBuilder;"), new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
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
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Ljava/util/List;", "GetBuildHandler")]
		public virtual global::System.Collections.IList Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Ljava/util/List;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
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
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='dispose' and count(parameter)=0]"
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

		static Delegate cb_getBuilder_I;
#pragma warning disable 0169
		static Delegate GetGetBuilder_IHandler ()
		{
			if (cb_getBuilder_I == null)
				cb_getBuilder_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetBuilder_I);
			return cb_getBuilder_I;
		}

		static IntPtr n_GetBuilder_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetBuilder (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getBuilder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='getBuilder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBuilder", "(I)Ljava/lang/Object;", "GetGetBuilder_IHandler")]
		public virtual global::Java.Lang.Object GetBuilder (int p0)
		{
			if (id_getBuilder_I == IntPtr.Zero)
				id_getBuilder_I = JNIEnv.GetMethodID (class_ref, "getBuilder", "(I)Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getBuilder_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuilder", "(I)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getMessage_I;
#pragma warning disable 0169
		static Delegate GetGetMessage_IHandler ()
		{
			if (cb_getMessage_I == null)
				cb_getMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMessage_I);
			return cb_getMessage_I;
		}

		static IntPtr n_GetMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMessage (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMessage", "(I)Lcom/google/protobuf/GeneratedMessage;", "GetGetMessage_IHandler")]
		public virtual global::Java.Lang.Object GetMessage (int p0)
		{
			if (id_getMessage_I == IntPtr.Zero)
				id_getMessage_I = JNIEnv.GetMethodID (class_ref, "getMessage", "(I)Lcom/google/protobuf/GeneratedMessage;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getMessage_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "(I)Lcom/google/protobuf/GeneratedMessage;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getMessageOrBuilder_I;
#pragma warning disable 0169
		static Delegate GetGetMessageOrBuilder_IHandler ()
		{
			if (cb_getMessageOrBuilder_I == null)
				cb_getMessageOrBuilder_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMessageOrBuilder_I);
			return cb_getMessageOrBuilder_I;
		}

		static IntPtr n_GetMessageOrBuilder_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMessageOrBuilder (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getMessageOrBuilder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='getMessageOrBuilder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMessageOrBuilder", "(I)Lcom/google/protobuf/MessageOrBuilder;", "GetGetMessageOrBuilder_IHandler")]
		public virtual global::Java.Lang.Object GetMessageOrBuilder (int p0)
		{
			if (id_getMessageOrBuilder_I == IntPtr.Zero)
				id_getMessageOrBuilder_I = JNIEnv.GetMethodID (class_ref, "getMessageOrBuilder", "(I)Lcom/google/protobuf/MessageOrBuilder;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getMessageOrBuilder_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageOrBuilder", "(I)Lcom/google/protobuf/MessageOrBuilder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkDirty ();
		}
#pragma warning restore 0169

		static IntPtr id_markDirty;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='markDirty' and count(parameter)=0]"
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

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Remove_I);
			return cb_remove_I;
		}

		static void n_Remove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)V", "GetRemove_IHandler")]
		public virtual void Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setMessage_ILcom_google_protobuf_GeneratedMessage_;
#pragma warning disable 0169
		static Delegate GetSetMessage_ILcom_google_protobuf_GeneratedMessage_Handler ()
		{
			if (cb_setMessage_ILcom_google_protobuf_GeneratedMessage_ == null)
				cb_setMessage_ILcom_google_protobuf_GeneratedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetMessage_ILcom_google_protobuf_GeneratedMessage_);
			return cb_setMessage_ILcom_google_protobuf_GeneratedMessage_;
		}

		static IntPtr n_SetMessage_ILcom_google_protobuf_GeneratedMessage_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Protobuf.RepeatedFieldBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMessage_ILcom_google_protobuf_GeneratedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RepeatedFieldBuilder']/method[@name='setMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.protobuf.GeneratedMessage']]"
		[Register ("setMessage", "(ILcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/RepeatedFieldBuilder;", "GetSetMessage_ILcom_google_protobuf_GeneratedMessage_Handler")]
		public virtual global::Com.Google.Protobuf.RepeatedFieldBuilder SetMessage (int p0, global::Java.Lang.Object p1)
		{
			if (id_setMessage_ILcom_google_protobuf_GeneratedMessage_ == IntPtr.Zero)
				id_setMessage_ILcom_google_protobuf_GeneratedMessage_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(ILcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/RepeatedFieldBuilder;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);

			global::Com.Google.Protobuf.RepeatedFieldBuilder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setMessage_ILcom_google_protobuf_GeneratedMessage_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.RepeatedFieldBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(ILcom/google/protobuf/GeneratedMessage;)Lcom/google/protobuf/RepeatedFieldBuilder;"), new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
