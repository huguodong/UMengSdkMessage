using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']"
	[global::Android.Runtime.Register ("com/umeng/message/UmengUT", DoNotGenerateAcw=true)]
	public partial class UmengUT : global::Java.Lang.Object, global::Org.Android.Agoo.UT.IUT {


		public static class InterfaceConsts {

			// The following are fields from: org.android.agoo.ut.UT

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.ut']/interface[@name='UT']/field[@name='AGOO_EVENT_ID']"
			[Register ("AGOO_EVENT_ID")]
			public const int AgooEventId = (int) 273791437;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.ut']/interface[@name='UT']/field[@name='NEW_EVENT_ID']"
			[Register ("NEW_EVENT_ID")]
			public const int NewEventId = (int) 66002;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/UmengUT", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UmengUT); }
		}

		protected UmengUT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']/constructor[@name='UmengUT' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public UmengUT () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UmengUT)) {
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

		static Delegate cb_commitEvent_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCommitEvent_ILjava_lang_Object_Handler ()
		{
			if (cb_commitEvent_ILjava_lang_Object_ == null)
				cb_commitEvent_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_CommitEvent_ILjava_lang_Object_);
			return cb_commitEvent_ILjava_lang_Object_;
		}

		static void n_CommitEvent_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.UmengUT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CommitEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_commitEvent_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']/method[@name='commitEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/Object;)V", "GetCommitEvent_ILjava_lang_Object_Handler")]
		public virtual void CommitEvent (int p0, global::Java.Lang.Object p1)
		{
			if (id_commitEvent_ILjava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_commitEvent_ILjava_lang_Object_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commitEvent", "(ILjava/lang/Object;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCommitEvent_ILjava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_ == null)
				cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_CommitEvent_ILjava_lang_Object_Ljava_lang_Object_);
			return cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_;
		}

		static void n_CommitEvent_ILjava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Message.UmengUT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CommitEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']/method[@name='commitEvent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;)V", "GetCommitEvent_ILjava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual void CommitEvent (int p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCommitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_CommitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_CommitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Umeng.Message.UmengUT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.CommitEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']/method[@name='commitEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "GetCommitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual void CommitEvent (int p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3)
		{
			if (id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCommitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_Handler ()
		{
			if (cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ == null)
				cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_CommitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_);
			return cb_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_;
		}

		static void n_CommitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Umeng.Message.UmengUT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			string[] p4 = (string[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.CommitEvent (p0, p1, p2, p3, p4);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		static IntPtr id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']/method[@name='commitEvent' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.String...']]"
		[Register ("commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)V", "GetCommitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_Handler")]
		public virtual void CommitEvent (int p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, params  string[] p4)
		{
			if (id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)V");
			IntPtr native_p4 = JNIEnv.NewArray (p4);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_convertObjectToString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']/method[@name='convertObjectToString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static string ConvertObjectToString (global::Java.Lang.Object p0)
		{
			if (id_convertObjectToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_convertObjectToString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertObjectToString_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getUtdId_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetUtdId_Landroid_content_Context_Handler ()
		{
			if (cb_getUtdId_Landroid_content_Context_ == null)
				cb_getUtdId_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUtdId_Landroid_content_Context_);
			return cb_getUtdId_Landroid_content_Context_;
		}

		static IntPtr n_GetUtdId_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.UmengUT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetUtdId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUtdId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']/method[@name='getUtdId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUtdId", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetUtdId_Landroid_content_Context_Handler")]
		public virtual string GetUtdId (global::Android.Content.Context p0)
		{
			if (id_getUtdId_Landroid_content_Context_ == IntPtr.Zero)
				id_getUtdId_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getUtdId", "(Landroid/content/Context;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUtdId_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUtdId", "(Landroid/content/Context;)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onCaughException_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnCaughException_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onCaughException_Ljava_lang_Throwable_ == null)
				cb_onCaughException_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCaughException_Ljava_lang_Throwable_);
			return cb_onCaughException_Ljava_lang_Throwable_;
		}

		static void n_OnCaughException_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.UmengUT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCaughException (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCaughException_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']/method[@name='onCaughException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onCaughException", "(Ljava/lang/Throwable;)V", "GetOnCaughException_Ljava_lang_Throwable_Handler")]
		public virtual void OnCaughException (global::Java.Lang.Throwable p0)
		{
			if (id_onCaughException_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onCaughException_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onCaughException", "(Ljava/lang/Throwable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCaughException_Ljava_lang_Throwable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCaughException", "(Ljava/lang/Throwable;)V"), new JValue (p0));
		}

		static Delegate cb_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStart_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Umeng.Message.UmengUT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Start (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']/method[@name='start' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("start", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetStart_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Start (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			if (id_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "start", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_stop_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetStop_Landroid_content_Context_Handler ()
		{
			if (cb_stop_Landroid_content_Context_ == null)
				cb_stop_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Stop_Landroid_content_Context_);
			return cb_stop_Landroid_content_Context_;
		}

		static void n_Stop_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.UmengUT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengUT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Stop (p0);
		}
#pragma warning restore 0169

		static IntPtr id_stop_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengUT']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stop", "(Landroid/content/Context;)V", "GetStop_Landroid_content_Context_Handler")]
		public virtual void Stop (global::Android.Content.Context p0)
		{
			if (id_stop_Landroid_content_Context_ == IntPtr.Zero)
				id_stop_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "stop", "(Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stop_Landroid_content_Context_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "(Landroid/content/Context;)V"), new JValue (p0));
		}

	}
}
