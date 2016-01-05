using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='H']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/H", DoNotGenerateAcw=true)]
	public partial class H : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/H", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (H); }
		}

		protected H (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='H']/constructor[@name='H' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public H () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (H)) {
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

		static Delegate cb_a_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_Map_Handler ()
		{
			if (cb_a_Ljava_util_Map_ == null)
				cb_a_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_Map_);
			return cb_a_Ljava_util_Map_;
		}

		static IntPtr n_A_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.H __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.H> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='H']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("a", "(Ljava/util/Map;)Ljava/util/List;", "GetA_Ljava_util_Map_Handler")]
		public virtual global::System.Collections.Generic.IList<string> A (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_a_Ljava_util_Map_ == IntPtr.Zero)
				id_a_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Map;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);

			global::System.Collections.Generic.IList<string> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_util_Map_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/util/Map;)Ljava/util/List;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_a_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetA_Lorg_json_JSONObject_Handler ()
		{
			if (cb_a_Lorg_json_JSONObject_ == null)
				cb_a_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lorg_json_JSONObject_);
			return cb_a_Lorg_json_JSONObject_;
		}

		static void n_A_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.H __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.H> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='H']/method[@name='a' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("a", "(Lorg/json/JSONObject;)V", "GetA_Lorg_json_JSONObject_Handler")]
		public virtual void A (global::Org.Json.JSONObject p0)
		{
			if (id_a_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_a_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "a", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

	}
}
