using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']"
	[Register ("org/android/spdy/SessionCb", "", "Org.Android.Spdy.ISessionCbInvoker")]
	public partial interface ISessionCb : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdyCustomControlFrameRecvCallback' and count(parameter)=7 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
		[Register ("spdyCustomControlFrameRecvCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;IIII[B)V", "GetSpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayBHandler:Org.Android.Spdy.ISessionCbInvoker, UMengSdkMessage")]
		void SpdyCustomControlFrameRecvCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, int p2, int p3, int p4, int p5, byte[] p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdyPingRecvCallback' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Object']]"
		[Register ("spdyPingRecvCallback", "(Lorg/android/spdy/SpdySession;JLjava/lang/Object;)V", "GetSpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_Handler:Org.Android.Spdy.ISessionCbInvoker, UMengSdkMessage")]
		void SpdyPingRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdySessionCloseCallback' and count(parameter)=4 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.android.spdy.SuperviseConnectInfo'] and parameter[4][@type='int']]"
		[Register ("spdySessionCloseCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;Lorg/android/spdy/SuperviseConnectInfo;I)V", "GetSpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_IHandler:Org.Android.Spdy.ISessionCbInvoker, UMengSdkMessage")]
		void SpdySessionCloseCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, global::Org.Android.Spdy.SuperviseConnectInfo p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdySessionConnectCB' and count(parameter)=2 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='org.android.spdy.SuperviseConnectInfo']]"
		[Register ("spdySessionConnectCB", "(Lorg/android/spdy/SpdySession;Lorg/android/spdy/SuperviseConnectInfo;)V", "GetSpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_Handler:Org.Android.Spdy.ISessionCbInvoker, UMengSdkMessage")]
		void SpdySessionConnectCB (global::Org.Android.Spdy.SpdySession p0, global::Org.Android.Spdy.SuperviseConnectInfo p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='SessionCb']/method[@name='spdySessionFailedError' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("spdySessionFailedError", "(Lorg/android/spdy/SpdySession;ILjava/lang/Object;)V", "GetSpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_Handler:Org.Android.Spdy.ISessionCbInvoker, UMengSdkMessage")]
		void SpdySessionFailedError (global::Org.Android.Spdy.SpdySession p0, int p1, global::Java.Lang.Object p2);

	}

	[global::Android.Runtime.Register ("org/android/spdy/SessionCb", DoNotGenerateAcw=true)]
	internal class ISessionCbInvoker : global::Java.Lang.Object, ISessionCb {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/spdy/SessionCb");
		IntPtr class_ref;

		public static ISessionCb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISessionCb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.spdy.SessionCb"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISessionCbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISessionCbInvoker); }
		}

		static Delegate cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB;
#pragma warning disable 0169
		static Delegate GetSpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayBHandler ()
		{
			if (cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB == null)
				cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr>) n_SpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB);
			return cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB;
		}

		static void n_SpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5, IntPtr native_p6)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p6 = (byte[]) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SpdyCustomControlFrameRecvCallback (p0, p1, p2, p3, p4, p5, p6);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
		}
#pragma warning restore 0169

		IntPtr id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB;
		public void SpdyCustomControlFrameRecvCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, int p2, int p3, int p4, int p5, byte[] p6)
		{
			if (id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB == IntPtr.Zero)
				id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB = JNIEnv.GetMethodID (class_ref, "spdyCustomControlFrameRecvCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;IIII[B)V");
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JNIEnv.CallVoidMethod (Handle, id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (native_p6));
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_Handler ()
		{
			if (cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ == null)
				cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_SpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_);
			return cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
		}

		static void n_SpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdyPingRecvCallback (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
		public void SpdyPingRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, global::Java.Lang.Object p2)
		{
			if (id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ == IntPtr.Zero)
				id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyPingRecvCallback", "(Lorg/android/spdy/SpdySession;JLjava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I;
#pragma warning disable 0169
		static Delegate GetSpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_IHandler ()
		{
			if (cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I == null)
				cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I);
			return cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I;
		}

		static void n_SpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SuperviseConnectInfo p2 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SuperviseConnectInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdySessionCloseCallback (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I;
		public void SpdySessionCloseCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, global::Org.Android.Spdy.SuperviseConnectInfo p2, int p3)
		{
			if (id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I == IntPtr.Zero)
				id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I = JNIEnv.GetMethodID (class_ref, "spdySessionCloseCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;Lorg/android/spdy/SuperviseConnectInfo;I)V");
			JNIEnv.CallVoidMethod (Handle, id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_;
#pragma warning disable 0169
		static Delegate GetSpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_Handler ()
		{
			if (cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ == null)
				cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_);
			return cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_;
		}

		static void n_SpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SuperviseConnectInfo p1 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SuperviseConnectInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SpdySessionConnectCB (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_;
		public void SpdySessionConnectCB (global::Org.Android.Spdy.SpdySession p0, global::Org.Android.Spdy.SuperviseConnectInfo p1)
		{
			if (id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ == IntPtr.Zero)
				id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ = JNIEnv.GetMethodID (class_ref, "spdySessionConnectCB", "(Lorg/android/spdy/SpdySession;Lorg/android/spdy/SuperviseConnectInfo;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_Handler ()
		{
			if (cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ == null)
				cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_);
			return cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_;
		}

		static void n_SpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Org.Android.Spdy.ISessionCb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISessionCb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdySessionFailedError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_;
		public void SpdySessionFailedError (global::Org.Android.Spdy.SpdySession p0, int p1, global::Java.Lang.Object p2)
		{
			if (id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ == IntPtr.Zero)
				id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdySessionFailedError", "(Lorg/android/spdy/SpdySession;ILjava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

}
