using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Mtop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHandler']"
	[global::Android.Runtime.Register ("org/android/agoo/net/mtop/MtopResponseHandler", DoNotGenerateAcw=true)]
	public abstract partial class MtopResponseHandler : global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHandler']/field[@name='g']"
		[Register ("g")]
		public const string G = (string) "SUCCESS";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHandler']/field[@name='h']"
		[Register ("h")]
		public const string H = (string) "FAIL";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHandler']/field[@name='i']"
		[Register ("i")]
		public const string I = (string) "ERROR_SERVICE_NOT_AVAILABLE";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/net/mtop/MtopResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MtopResponseHandler); }
		}

		protected MtopResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHandler']/constructor[@name='MtopResponseHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MtopResponseHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MtopResponseHandler)) {
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

		static Delegate cb_onFailure_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onFailure_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onFailure_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_String_Ljava_lang_String_);
			return cb_onFailure_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnFailure_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Net.Mtop.MtopResponseHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Mtop.MtopResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onFailure_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHandler']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFailure", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void OnFailure (string p0, string p1)
		{
			if (id_onFailure_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onFailure_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFailure", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	[global::Android.Runtime.Register ("org/android/agoo/net/mtop/MtopResponseHandler", DoNotGenerateAcw=true)]
	internal partial class MtopResponseHandlerInvoker : MtopResponseHandler {

		public MtopResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MtopResponseHandlerInvoker); }
		}

	}

}
