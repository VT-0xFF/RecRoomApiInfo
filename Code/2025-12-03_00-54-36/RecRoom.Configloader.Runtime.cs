using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Configloader_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80DCA30", Offset = "0x80DB630", VA = "0x1880DCA30", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Configs
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class JYRNICHWDLY
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Log ZTONUVSKEWL;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3727000", Offset = "0x3725C00", VA = "0x183727000")]
		public static T Load<T>([Optional] string name) where T : ScriptableObject
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3726F10", Offset = "0x3725B10", VA = "0x183726F10")]
		public static string IRJILMBOEQK<a>([Optional] string a) where a : ScriptableObject
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static T _instance;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected virtual bool GFTQHYKYTME
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static T PGFSJHGESKI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5D6EE80", Offset = "0x5D6DA80", VA = "0x185D6EE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
		protected virtual void OKFMPOAEAOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D6EC30", Offset = "0x5D6D830", VA = "0x185D6EC30", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D6ECE0", Offset = "0x5D6D8E0", VA = "0x185D6ECE0", Slot = "7")]
		protected virtual void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D6EDC0", Offset = "0x5D6D9C0", VA = "0x185D6EDC0")]
		private void HMPBXZLOHLU(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB904D0", Offset = "0xB8F0D0", VA = "0x180B904D0")]
		public SingletonScriptableObject()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
