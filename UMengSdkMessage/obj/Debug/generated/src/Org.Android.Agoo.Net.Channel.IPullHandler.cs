using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IPullHandler']"
	[Register ("org/android/agoo/net/channel/IPullHandler", "", "Org.Android.Agoo.Net.Channel.IPullHandlerInvoker")]
	public partial interface IPullHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IPullHandler']/method[@name='onResponse' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.util.Map'] and parameter[5][@type='byte[]']]"
		[Register ("onResponse", "(Ljava/lang/Object;Ljava/lang/String;ILjava/util/Map;[B)V", "GetOnResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayBHandler:Org.Android.Agoo.Net.Channel.IPullHandlerInvoker, UMengSdkMessage")]
		void OnResponse (global::Java.Lang.Object p0, string p1, int p2, global::System.Collections.Generic.IDictionary<string, string> p3, byte[] p4);

	}

	[global::Android.Runtime.Register ("org/android/agoo/net/channel/IPullHandler", DoNotGenerateAcw=true)]
	internal class IPullHandlerInvoker : global::Java.Lang.Object, IPullHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/net/channel/IPullHandler");
		IntPtr class_ref;

		public static IPullHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPullHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.net.channel.IPullHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPullHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPullHandlerInvoker); }
		}

		static Delegate cb_onResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayB;
#pragma warning disable 0169
		static Delegate GetOnResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayBHandler ()
		{
			if (cb_onResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayB == null)
				cb_onResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayB);
			return cb_onResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayB;
		}

		static void n_OnResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Android.Agoo.Net.Channel.IPullHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IPullHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			byte[] p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnResponse (p0, p1, p2, p3, p4);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayB;
		public void OnResponse (global::Java.Lang.Object p0, string p1, int p2, global::System.Collections.Generic.IDictionary<string, string> p3, byte[] p4)
		{
			if (id_onResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayB == IntPtr.Zero)
				id_onResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayB = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/lang/Object;Ljava/lang/String;ILjava/util/Map;[B)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JNIEnv.CallVoidMethod (Handle, id_onResponse_Ljava_lang_Object_Ljava_lang_String_ILjava_util_Map_arrayB, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}

}
