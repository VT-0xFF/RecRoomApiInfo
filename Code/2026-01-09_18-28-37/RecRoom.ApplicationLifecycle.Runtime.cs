using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_ApplicationLifecycle_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F47760", Offset = "0x7F46B60", VA = "0x187F47760", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x273A690", VA = "0x18273B290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class FYEPHKSCXTN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Thread CXTBKVCSTQX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool IVJHNXWGVBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7F475E0", Offset = "0x7F469E0", VA = "0x187F475E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F47590", Offset = "0x7F46990", VA = "0x187F47590")]
		[RRRuntimeInitializeMethod]
		internal static void HUWTROQPORD()
		{
		}
	}
}
namespace RecRoom.ApplicationLifecycle
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface XQARFUOJUDZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ApplicationFocusEvent AISCSXFVPLG;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event UpdateEvent DOOAFFSZWJB;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event FixedUpdateEvent ZLCCLJCECAV;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event LateUpdateEvent YMBFDDOHGCD;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event PostUpdateEvent QECSTXFQTQZ;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event PreRenderUpdateEvent ASCDNUDKOVE;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event LatePreRenderUpdateEvent ETXZLFFPZBU;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RigidbodyExLateUpdateEvent PDYCFTVLNKJ;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event PostNetworkReceiveEvent EQHYCLEHXKH;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event EndOfFrameEvent NHNBPYNJOYT;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void UpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void FixedUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void LateUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void PreRenderUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void LatePreRenderUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void RigidbodyExLateUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void PostNetworkReceiveEvent();
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate void PostUpdateEvent();
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void ApplicationFocusEvent(bool hasFocus);
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate void EndOfFrameEvent();
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F473C0", Offset = "0x7F467C0", VA = "0x187F473C0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F474C0", Offset = "0x7F468C0", VA = "0x187F474C0")]
		public static void SafeDestroyGameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
		public ApplicationQuitBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class PZQXOPGUQWT
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static bool ZRSFIWLNLUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7F476E0", Offset = "0x7F46AE0", VA = "0x187F476E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F47630", Offset = "0x7F46A30", VA = "0x187F47630")]
		[RRRuntimeInitializeMethod.AfterSceneLoad]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F47720", Offset = "0x7F46B20", VA = "0x187F47720")]
		internal static void TYLIPCJSDXW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface KDAFEAYUEKC
	{
		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<bool> OGOLTSFXATK;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetInnerFocusProvider(KDAFEAYUEKC innerProvider);
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
