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
		[Cpp2IlInjected.Address(RVA = "0x975ADD0", Offset = "0x97597D0", VA = "0x18975ADD0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Configs
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class RDAWCFQVOER
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Log AWZAYZHQABY;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3E3CC20", Offset = "0x3E3B620", VA = "0x183E3CC20")]
		public static T Load<T>([Optional] string name) where T : ScriptableObject
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3E3CED0", Offset = "0x3E3B8D0", VA = "0x183E3CED0")]
		public static string MAEYERWSZJL<a>([Optional] string a) where a : ScriptableObject
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
		protected virtual bool GTDXFOESXIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static T UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7973E00", Offset = "0x7972800", VA = "0x187973E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
		protected virtual void WGKOFQBVOGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7973BB0", Offset = "0x79725B0", VA = "0x187973BB0", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7973C60", Offset = "0x7972660", VA = "0x187973C60", Slot = "7")]
		protected virtual void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7973D40", Offset = "0x7972740", VA = "0x187973D40")]
		private void SHORFCMAUCJ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD88820", Offset = "0xD87220", VA = "0x180D88820")]
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
