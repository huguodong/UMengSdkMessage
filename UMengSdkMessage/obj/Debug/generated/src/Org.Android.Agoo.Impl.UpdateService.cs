using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='UpdateService']"
	[global::Android.Runtime.Register ("org/android/agoo/impl/UpdateService", DoNotGenerateAcw=true)]
	public partial class UpdateService : global::Java.Lang.Object, global::Org.Android.Agoo.IUpdateService {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/impl/UpdateService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UpdateService); }
		}

		protected UpdateService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='UpdateService']/constructor[@name='UpdateService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public UpdateService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UpdateService)) {
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

		static Delegate cb_checkUpdateJar_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckUpdateJar_ILjava_lang_String_Handler ()
		{
			if (cb_checkUpdateJar_ILjava_lang_String_ == null)
				cb_checkUpdateJar_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_CheckUpdateJar_ILjava_lang_String_);
			return cb_checkUpdateJar_ILjava_lang_String_;
		}

		static bool n_CheckUpdateJar_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Impl.UpdateService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.UpdateService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckUpdateJar (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_checkUpdateJar_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='UpdateService']/method[@name='checkUpdateJar' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkUpdateJar", "(ILjava/lang/String;)Z", "GetCheckUpdateJar_ILjava_lang_String_Handler")]
		public virtual bool CheckUpdateJar (int p0, string p1)
		{
			if (id_checkUpdateJar_ILjava_lang_String_ == IntPtr.Zero)
				id_checkUpdateJar_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkUpdateJar", "(ILjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_checkUpdateJar_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkUpdateJar", "(ILjava/lang/String;)Z"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDownloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DownloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Android.Agoo.Impl.UpdateService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Impl.UpdateService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DownloadUpdate (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='UpdateService']/method[@name='downloadUpdate' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("downloadUpdate", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetDownloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void DownloadUpdate (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "downloadUpdate", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadUpdate", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}
