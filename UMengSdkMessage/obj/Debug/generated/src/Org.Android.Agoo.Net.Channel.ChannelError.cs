using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']"
	[global::Android.Runtime.Register ("org/android/agoo/net/channel/ChannelError", DoNotGenerateAcw=true)]
	public sealed partial class ChannelError : global::Java.Lang.Enum {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='a']"
		[Register ("a")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='b']"
		[Register ("b")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='c']"
		[Register ("c")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='d']"
		[Register ("d")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, d_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, d_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='e']"
		[Register ("e")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, e_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, e_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr f_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='f']"
		[Register ("f")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError F {
			get {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, f_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, f_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr g_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='g']"
		[Register ("g")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError G {
			get {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, g_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, g_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr h_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='h']"
		[Register ("h")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError H {
			get {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, h_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, h_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr i_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='i']"
		[Register ("i")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError I {
			get {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, i_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, i_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr j_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='j']"
		[Register ("j")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError J {
			get {
				if (j_jfieldId == IntPtr.Zero)
					j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, j_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (j_jfieldId == IntPtr.Zero)
					j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, j_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr k_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='k']"
		[Register ("k")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError K {
			get {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "k", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, k_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "k", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, k_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr l_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='l']"
		[Register ("l")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError L {
			get {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "l", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, l_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "l", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, l_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='m']"
		[Register ("m")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError M {
			get {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, m_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, m_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='n']"
		[Register ("n")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError N {
			get {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "n", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, n_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "n", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, n_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr o_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='o']"
		[Register ("o")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError O {
			get {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "o", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, o_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "o", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, o_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='p']"
		[Register ("p")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError P {
			get {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "p", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, p_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "p", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, p_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr q_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='q']"
		[Register ("q")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError Q {
			get {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "q", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, q_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "q", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, q_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr r_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='r']"
		[Register ("r")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError R {
			get {
				if (r_jfieldId == IntPtr.Zero)
					r_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "r", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, r_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (r_jfieldId == IntPtr.Zero)
					r_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "r", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, r_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr s_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='s']"
		[Register ("s")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError S {
			get {
				if (s_jfieldId == IntPtr.Zero)
					s_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "s", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, s_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (s_jfieldId == IntPtr.Zero)
					s_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "s", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, s_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr t_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='t']"
		[Register ("t")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError T {
			get {
				if (t_jfieldId == IntPtr.Zero)
					t_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "t", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, t_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (t_jfieldId == IntPtr.Zero)
					t_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "t", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, t_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr u_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='u']"
		[Register ("u")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError U {
			get {
				if (u_jfieldId == IntPtr.Zero)
					u_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "u", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, u_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (u_jfieldId == IntPtr.Zero)
					u_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "u", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, u_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr v_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='v']"
		[Register ("v")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError V {
			get {
				if (v_jfieldId == IntPtr.Zero)
					v_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "v", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, v_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (v_jfieldId == IntPtr.Zero)
					v_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "v", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, v_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr w_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='w']"
		[Register ("w")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError W {
			get {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "w", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, w_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "w", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, w_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='x']"
		[Register ("x")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "x", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, x_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "x", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, x_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='y']"
		[Register ("y")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError Y {
			get {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "y", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, y_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "y", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, y_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr z_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/field[@name='z']"
		[Register ("z")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError Z {
			get {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "z", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, z_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "z", "Lorg/android/agoo/net/channel/ChannelError;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, z_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']"
		[global::Android.Runtime.Register ("org/android/agoo/net/channel/ChannelError$Level", DoNotGenerateAcw=true)]
		public sealed partial class Level : global::Java.Lang.Enum {


			static IntPtr a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']/field[@name='a']"
			[Register ("a")]
			public static global::Org.Android.Agoo.Net.Channel.ChannelError.Level A {
				get {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']/field[@name='b']"
			[Register ("b")]
			public static global::Org.Android.Agoo.Net.Channel.ChannelError.Level B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']/field[@name='c']"
			[Register ("c")]
			public static global::Org.Android.Agoo.Net.Channel.ChannelError.Level C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr d_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']/field[@name='d']"
			[Register ("d")]
			public static global::Org.Android.Agoo.Net.Channel.ChannelError.Level D {
				get {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, d_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, d_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr e_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']/field[@name='e']"
			[Register ("e")]
			public static global::Org.Android.Agoo.Net.Channel.ChannelError.Level E {
				get {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, e_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, e_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr f_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']/field[@name='f']"
			[Register ("f")]
			public static global::Org.Android.Agoo.Net.Channel.ChannelError.Level F {
				get {
					if (f_jfieldId == IntPtr.Zero)
						f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, f_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (f_jfieldId == IntPtr.Zero)
						f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, f_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr g_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']/field[@name='g']"
			[Register ("g")]
			public static global::Org.Android.Agoo.Net.Channel.ChannelError.Level G {
				get {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, g_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, g_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr h_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']/field[@name='h']"
			[Register ("h")]
			public static global::Org.Android.Agoo.Net.Channel.ChannelError.Level H {
				get {
					if (h_jfieldId == IntPtr.Zero)
						h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, h_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (h_jfieldId == IntPtr.Zero)
						h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Lorg/android/agoo/net/channel/ChannelError$Level;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, h_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/android/agoo/net/channel/ChannelError$Level", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Level); }
			}

			internal Level (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelError$Level;", "")]
			public static global::Org.Android.Agoo.Net.Channel.ChannelError.Level ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelError$Level;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Org.Android.Agoo.Net.Channel.ChannelError.Level __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError.Level> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError.Level']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/android/agoo/net/channel/ChannelError$Level;", "")]
			public static global::Org.Android.Agoo.Net.Channel.ChannelError.Level[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/agoo/net/channel/ChannelError$Level;");
				return (global::Org.Android.Agoo.Net.Channel.ChannelError.Level[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Agoo.Net.Channel.ChannelError.Level));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/net/channel/ChannelError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelError); }
		}

		internal ChannelError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getChannelLevel;
		public global::Org.Android.Agoo.Net.Channel.ChannelError.Level ChannelLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/method[@name='getChannelLevel' and count(parameter)=0]"
			[Register ("getChannelLevel", "()Lorg/android/agoo/net/channel/ChannelError$Level;", "GetGetChannelLevelHandler")]
			get {
				if (id_getChannelLevel == IntPtr.Zero)
					id_getChannelLevel = JNIEnv.GetMethodID (class_ref, "getChannelLevel", "()Lorg/android/agoo/net/channel/ChannelError$Level;");
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError.Level> (JNIEnv.CallObjectMethod  (Handle, id_getChannelLevel), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getErrorCode;
		public int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getErrorCode);
			}
		}

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lorg/android/agoo/net/channel/ChannelError;", "")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetStaticMethodID (class_ref, "get", "(I)Lorg/android/agoo/net/channel/ChannelError;");
			return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getEasySpdy_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/method[@name='getEasySpdy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getEasySpdy", "(I)Lorg/android/agoo/net/channel/ChannelError;", "")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError GetEasySpdy (int p0)
		{
			if (id_getEasySpdy_I == IntPtr.Zero)
				id_getEasySpdy_I = JNIEnv.GetStaticMethodID (class_ref, "getEasySpdy", "(I)Lorg/android/agoo/net/channel/ChannelError;");
			return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEasySpdy_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelError;", "")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelError;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Android.Agoo.Net.Channel.ChannelError __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelError']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/android/agoo/net/channel/ChannelError;", "")]
		public static global::Org.Android.Agoo.Net.Channel.ChannelError[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/agoo/net/channel/ChannelError;");
			return (global::Org.Android.Agoo.Net.Channel.ChannelError[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Agoo.Net.Channel.ChannelError));
		}

	}
}
