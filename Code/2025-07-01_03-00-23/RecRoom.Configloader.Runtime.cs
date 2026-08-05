using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Configloader_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2BB0", Offset = "0x7EC11B0", VA = "0x187EC2BB0", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KIHECLFPFEN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static LHMKAIAPMBI OAAFJAHOMDO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3980", Offset = "0x3BD1F80", VA = "0x183BD3980")]
	public static T OPEHIIFBIEO<T>([Optional] string IEDAJGLJHNI) where T : ScriptableObject
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3890", Offset = "0x3BD1E90", VA = "0x183BD3890")]
	public static string CJIGGGLBCEB<T>([Optional] string IEDAJGLJHNI) where T : ScriptableObject
	{
		return null;
	}
}
namespace RecRoom.Configs
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static T _instance;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected virtual bool doCleanupOnEmptyScene
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static T Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5B1AF90", Offset = "0x5B19590", VA = "0x185B1AF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		protected virtual void ILJBMAKPGGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B1AD20", Offset = "0x5B19320", VA = "0x185B1AD20", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1ADE0", Offset = "0x5B193E0", VA = "0x185B1ADE0", Slot = "7")]
		protected virtual void GLGIKECFEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B1AED0", Offset = "0x5B194D0", VA = "0x185B1AED0")]
		private void MOJAHIPBOHK(Scene EOECEDBNACA, LoadSceneMode HMNPOEHONDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC6D2F0", Offset = "0xC6B8F0", VA = "0x180C6D2F0")]
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
