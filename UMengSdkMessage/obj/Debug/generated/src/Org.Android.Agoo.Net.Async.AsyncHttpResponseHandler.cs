using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']"
	[global::Android.Runtime.Register ("org/android/agoo/net/async/AsyncHttpResponseHandler", DoNotGenerateAcw=true)]
	public partial class AsyncHttpResponseHandler : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/field[@name='c']"
		[Register ("c")]
		protected const int C = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/field[@name='d']"
		[Register ("d")]
		protected const int D = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/field[@name='e']"
		[Register ("e")]
		protected const int E = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/field[@name='f']"
		[Register ("f")]
		protected const int F = (int) 3;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/net/async/AsyncHttpResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpResponseHandler); }
		}

		protected AsyncHttpResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/constructor[@name='AsyncHttpResponseHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AsyncHttpResponseHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AsyncHttpResponseHandler)) {
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

		static Delegate cb_a_Ljava_util_Map_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_Map_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_util_Map_Ljava_lang_String_ == null)
				cb_a_Ljava_util_Map_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_Map_Ljava_lang_String_);
			return cb_a_Ljava_util_Map_Ljava_lang_String_;
		}

		static void n_A_Ljava_util_Map_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_util_Map_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/util/Map;Ljava/lang/String;)V", "GetA_Ljava_util_Map_Ljava_lang_String_Handler")]
		protected virtual void A (global::System.Collections.Generic.IDictionary<string, string> p0, string p1)
		{
			if (id_a_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Map;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_Map_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/util/Map;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_b_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_Throwable_Handler ()
		{
			if (cb_b_Ljava_lang_Throwable_ == null)
				cb_b_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_B_Ljava_lang_Throwable_);
			return cb_b_Ljava_lang_Throwable_;
		}

		static void n_B_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		static IntPtr id_b_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("b", "(Ljava/lang/Throwable;)V", "GetB_Ljava_lang_Throwable_Handler")]
		protected virtual void B (global::Java.Lang.Throwable p0)
		{
			if (id_b_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_b_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Throwable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_Throwable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Ljava/lang/Throwable;)V"), new JValue (p0));
		}

		static Delegate cb_onFailure_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFailure_Ljava_lang_Throwable_ == null)
				cb_onFailure_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_Throwable_);
			return cb_onFailure_Ljava_lang_Throwable_;
		}

		static void n_OnFailure_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onFailure_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onFailure", "(Ljava/lang/Throwable;)V", "GetOnFailure_Ljava_lang_Throwable_Handler")]
		public virtual void OnFailure (global::Java.Lang.Throwable p0)
		{
			if (id_onFailure_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/Throwable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onFailure_Ljava_lang_Throwable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFailure", "(Ljava/lang/Throwable;)V"), new JValue (p0));
		}

		static Delegate cb_onFailure_Ljava_lang_Throwable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_Throwable_Ljava_lang_String_Handler ()
		{
			if (cb_onFailure_Ljava_lang_Throwable_Ljava_lang_String_ == null)
				cb_onFailure_Ljava_lang_Throwable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_Throwable_Ljava_lang_String_);
			return cb_onFailure_Ljava_lang_Throwable_Ljava_lang_String_;
		}

		static void n_OnFailure_Ljava_lang_Throwable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onFailure_Ljava_lang_Throwable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFailure", "(Ljava/lang/Throwable;Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_Throwable_Ljava_lang_String_Handler")]
		public virtual void OnFailure (global::Java.Lang.Throwable p0, string p1)
		{
			if (id_onFailure_Ljava_lang_Throwable_Ljava_lang_String_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_Throwable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/Throwable;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onFailure_Ljava_lang_Throwable_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFailure", "(Ljava/lang/Throwable;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_Handler ()
		{
			if (cb_onFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_ == null)
				cb_onFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_);
			return cb_onFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_;
		}

		static void n_OnFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/method[@name='onFailure' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='java.lang.String']]"
		[Register ("onFailure", "(Ljava/lang/Throwable;Ljava/util/Map;Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_Handler")]
		public virtual void OnFailure (global::Java.Lang.Throwable p0, global::System.Collections.Generic.IDictionary<string, string> p1, string p2)
		{
			if (id_onFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/Throwable;Ljava/util/Map;Ljava/lang/String;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onFailure_Ljava_lang_Throwable_Ljava_util_Map_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFailure", "(Ljava/lang/Throwable;Ljava/util/Map;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_onFinish;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/method[@name='onFinish' and count(parameter)=0]"
		[Register ("onFinish", "()V", "")]
		public void OnFinish ()
		{
			if (id_onFinish == IntPtr.Zero)
				id_onFinish = JNIEnv.GetMethodID (class_ref, "onFinish", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onFinish);
		}

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "")]
		public void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onStart);
		}

		static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSuccess_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler")]
		public virtual void OnSuccess (string p0)
		{
			if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSuccess_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSuccess", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onSuccess_Ljava_util_Map_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_util_Map_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_util_Map_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_util_Map_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_util_Map_Ljava_lang_String_);
			return cb_onSuccess_Ljava_util_Map_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_util_Map_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Async.AsyncHttpResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSuccess_Ljava_util_Map_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.async']/class[@name='AsyncHttpResponseHandler']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/util/Map;Ljava/lang/String;)V", "GetOnSuccess_Ljava_util_Map_Ljava_lang_String_Handler")]
		public virtual void OnSuccess (global::System.Collections.Generic.IDictionary<string, string> p0, string p1)
		{
			if (id_onSuccess_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/util/Map;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSuccess_Ljava_util_Map_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSuccess", "(Ljava/util/Map;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
