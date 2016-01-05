using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.UT.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']"
	[global::Android.Runtime.Register ("org/android/agoo/ut/impl/Usertrace", DoNotGenerateAcw=true)]
	public sealed partial class Usertrace : global::Java.Lang.Object, global::Org.Android.Agoo.UT.IUT {


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
				return JNIEnv.FindClass ("org/android/agoo/ut/impl/Usertrace", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Usertrace); }
		}

		internal Usertrace (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']/constructor[@name='Usertrace' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Usertrace () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Usertrace)) {
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

		static IntPtr id_commitEvent_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']/method[@name='commitEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/Object;)V", "")]
		public void CommitEvent (int p0, global::Java.Lang.Object p1)
		{
			if (id_commitEvent_ILjava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_commitEvent_ILjava_lang_Object_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']/method[@name='commitEvent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;)V", "")]
		public void CommitEvent (int p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']/method[@name='commitEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public void CommitEvent (int p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3)
		{
			if (id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']/method[@name='commitEvent' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.String...']]"
		[Register ("commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)V", "")]
		public void CommitEvent (int p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, params  string[] p4)
		{
			if (id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ == IntPtr.Zero)
				id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/String;)V");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JNIEnv.CallVoidMethod  (Handle, id_commitEvent_ILjava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_arrayLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4));
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_convertObjectToString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']/method[@name='convertObjectToString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static string ConvertObjectToString (global::Java.Lang.Object p0)
		{
			if (id_convertObjectToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_convertObjectToString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertObjectToString_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getUtdId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']/method[@name='getUtdId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUtdId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public string GetUtdId (global::Android.Content.Context p0)
		{
			if (id_getUtdId_Landroid_content_Context_ == IntPtr.Zero)
				id_getUtdId_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getUtdId", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUtdId_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_onCaughException_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']/method[@name='onCaughException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onCaughException", "(Ljava/lang/Throwable;)V", "")]
		public void OnCaughException (global::Java.Lang.Throwable p0)
		{
			if (id_onCaughException_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onCaughException_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onCaughException", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onCaughException_Ljava_lang_Throwable_, new JValue (p0));
		}

		static IntPtr id_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']/method[@name='start' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("start", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void Start (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			if (id_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "start", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallVoidMethod  (Handle, id_start_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_stop_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut.impl']/class[@name='Usertrace']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stop", "(Landroid/content/Context;)V", "")]
		public void Stop (global::Android.Content.Context p0)
		{
			if (id_stop_Landroid_content_Context_ == IntPtr.Zero)
				id_stop_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "stop", "(Landroid/content/Context;)V");
			JNIEnv.CallVoidMethod  (Handle, id_stop_Landroid_content_Context_, new JValue (p0));
		}

	}
}
