using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyRequest", DoNotGenerateAcw=true)]
	public sealed partial class SpdyRequest : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/field[@name='GET_METHOD']"
		[Register ("GET_METHOD")]
		public const string GetMethod = (string) "GET";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/field[@name='POST_METHOD']"
		[Register ("POST_METHOD")]
		public const string PostMethod = (string) "POST";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyRequest); }
		}

		internal SpdyRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=10 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='org.android.spdy.RequestPriority'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V", "")]
		public SpdyRequest (global::Java.Net.URL p0, string p1, int p2, string p3, int p4, string p5, global::Org.Android.Spdy.RequestPriority p6, int p7, int p8, int p9) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p3 = JNIEnv.NewString (p3);;
			IntPtr native_p5 = JNIEnv.NewString (p5);;
			if (GetType () != typeof (SpdyRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (p4), new JValue (native_p5), new JValue (p6), new JValue (p7), new JValue (p8), new JValue (p9)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (p4), new JValue (native_p5), new JValue (p6), new JValue (p7), new JValue (p8), new JValue (p9));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
				return;
			}

			if (id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III == IntPtr.Zero)
				id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;III)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (p4), new JValue (native_p5), new JValue (p6), new JValue (p7), new JValue (p8), new JValue (p9)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_III, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (p4), new JValue (native_p5), new JValue (p6), new JValue (p7), new JValue (p8), new JValue (p9));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=5 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='org.android.spdy.RequestPriority']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V", "")]
		public SpdyRequest (global::Java.Net.URL p0, string p1, int p2, string p3, global::Org.Android.Spdy.RequestPriority p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p3 = JNIEnv.NewString (p3);;
			if (GetType () != typeof (SpdyRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_ == IntPtr.Zero)
				id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;ILjava/lang/String;Lorg/android/spdy/RequestPriority;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_ILjava_lang_String_Lorg_android_spdy_RequestPriority_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=3 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.android.spdy.RequestPriority']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V", "")]
		public SpdyRequest (global::Java.Net.URL p0, string p1, global::Org.Android.Spdy.RequestPriority p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (SpdyRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_ == IntPtr.Zero)
				id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=5 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.android.spdy.RequestPriority'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V", "")]
		public SpdyRequest (global::Java.Net.URL p0, string p1, global::Org.Android.Spdy.RequestPriority p2, int p3, int p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (SpdyRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II == IntPtr.Zero)
				id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;Lorg/android/spdy/RequestPriority;II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_Lorg_android_spdy_RequestPriority_II, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/constructor[@name='SpdyRequest' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/String;)V", "")]
		public SpdyRequest (global::Java.Net.URL p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (SpdyRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URL;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/URL;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_net_URL_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_net_URL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_getConnectionTimeoutMs;
		public int ConnectionTimeoutMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='getConnectionTimeoutMs' and count(parameter)=0]"
			[Register ("getConnectionTimeoutMs", "()I", "GetGetConnectionTimeoutMsHandler")]
			get {
				if (id_getConnectionTimeoutMs == IntPtr.Zero)
					id_getConnectionTimeoutMs = JNIEnv.GetMethodID (class_ref, "getConnectionTimeoutMs", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getConnectionTimeoutMs);
			}
		}

		static IntPtr id_getRequestTimeoutMs;
		public int RequestTimeoutMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='getRequestTimeoutMs' and count(parameter)=0]"
			[Register ("getRequestTimeoutMs", "()I", "GetGetRequestTimeoutMsHandler")]
			get {
				if (id_getRequestTimeoutMs == IntPtr.Zero)
					id_getRequestTimeoutMs = JNIEnv.GetMethodID (class_ref, "getRequestTimeoutMs", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getRequestTimeoutMs);
			}
		}

		static IntPtr id_getRetryTimes;
		public int RetryTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='getRetryTimes' and count(parameter)=0]"
			[Register ("getRetryTimes", "()I", "GetGetRetryTimesHandler")]
			get {
				if (id_getRetryTimes == IntPtr.Zero)
					id_getRetryTimes = JNIEnv.GetMethodID (class_ref, "getRetryTimes", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getRetryTimes);
			}
		}

		static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_addHeaders_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyRequest']/method[@name='addHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("addHeaders", "(Ljava/util/Map;)V", "")]
		public void AddHeaders (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_addHeaders_Ljava_util_Map_ == IntPtr.Zero)
				id_addHeaders_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "addHeaders", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_addHeaders_Ljava_util_Map_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
