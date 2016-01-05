using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']"
	[global::Android.Runtime.Register ("org/android/agoo/net/async/RequestParams", DoNotGenerateAcw=true)]
	public sealed partial class RequestParams : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/net/async/RequestParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestParams); }
		}

		internal RequestParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']/constructor[@name='RequestParams' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public RequestParams (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (RequestParams)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']/constructor[@name='RequestParams' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public RequestParams (global::System.Collections.Generic.IDictionary<string, string> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (RequestParams)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Map;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Map;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_Map_ == IntPtr.Zero)
				id_ctor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Map_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']/constructor[@name='RequestParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RequestParams () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestParams)) {
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

		static IntPtr id_getEntity;
		public global::Org.Apache.Http.IHttpEntity Entity {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']/method[@name='getEntity' and count(parameter)=0]"
			[Register ("getEntity", "()Lorg/apache/http/HttpEntity;", "GetGetEntityHandler")]
			get {
				if (id_getEntity == IntPtr.Zero)
					id_getEntity = JNIEnv.GetMethodID (class_ref, "getEntity", "()Lorg/apache/http/HttpEntity;");
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpEntity> (JNIEnv.CallObjectMethod  (Handle, id_getEntity), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getParamString;
		public string ParamString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']/method[@name='getParamString' and count(parameter)=0]"
			[Register ("getParamString", "()Ljava/lang/String;", "GetGetParamStringHandler")]
			get {
				if (id_getParamString == IntPtr.Zero)
					id_getParamString = JNIEnv.GetMethodID (class_ref, "getParamString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getParamString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/util/List;", "")]
		protected global::System.Collections.Generic.IList<global::Org.Apache.Http.Message.BasicNameValuePair> A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Org.Apache.Http.Message.BasicNameValuePair>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_format_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("format", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static string Format (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_format_Ljava_util_Map_ == IntPtr.Zero)
				id_format_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "format", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_format_Ljava_util_Map_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "")]
		public void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_remove_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='RequestParams']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
