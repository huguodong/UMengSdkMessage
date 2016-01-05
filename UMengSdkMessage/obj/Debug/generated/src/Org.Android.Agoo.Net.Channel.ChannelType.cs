using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelType']"
	[global::Android.Runtime.Register ("org/android/agoo/net/channel/ChannelType", DoNotGenerateAcw=true)]
	public sealed partial class ChannelType : global::Java.Lang.Enum {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelType']/field[@name='a']"
		[Register ("a")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelType A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lorg/android/agoo/net/channel/ChannelType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lorg/android/agoo/net/channel/ChannelType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelType']/field[@name='b']"
		[Register ("b")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelType B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lorg/android/agoo/net/channel/ChannelType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lorg/android/agoo/net/channel/ChannelType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/net/channel/ChannelType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelType); }
		}

		internal ChannelType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDesc;
		public string Desc {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelType']/method[@name='getDesc' and count(parameter)=0]"
			[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler")]
			get {
				if (id_getDesc == IntPtr.Zero)
					id_getDesc = JNIEnv.GetMethodID (class_ref, "getDesc", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDesc), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getValue;
		public int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelType']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getValue);
			}
		}

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelType']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lorg/android/agoo/net/channel/ChannelType;", "")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelType Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetStaticMethodID (class_ref, "get", "(I)Lorg/android/agoo/net/channel/ChannelType;");
			return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelType;", "")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Android.Agoo.Net.Channel.ChannelType __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/android/agoo/net/channel/ChannelType;", "")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/agoo/net/channel/ChannelType;");
			return (global::Org.Android.Agoo.Net.Channel.ChannelType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Agoo.Net.Channel.ChannelType));
		}

	}
}
