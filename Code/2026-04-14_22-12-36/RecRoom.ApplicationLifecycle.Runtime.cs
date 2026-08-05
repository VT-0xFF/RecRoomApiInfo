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
		[Cpp2IlInjected.Address(RVA = "0x9564240", Offset = "0x9562E40", VA = "0x189564240", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F8180", Offset = "0x29F6D80", VA = "0x1829F8180")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class OBGWBZIGDAZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Thread LJTNAHSQOLT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool COCLLZWZXPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x95640C0", Offset = "0x9562CC0", VA = "0x1895640C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9564060", Offset = "0x9562C60", VA = "0x189564060")]
		[RRRuntimeInitializeMethod]
		internal static void KKBMLZYGTKX()
		{
		}
	}
}
namespace RecRoom.ApplicationLifecycle
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface IMVETHGUJYJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ApplicationFocusEvent XQUJZHYFLWC;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event UpdateEvent YMWGDHQDGEJ;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event FixedUpdateEvent KSVFRFNDLPZ;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event LateUpdateEvent CAIXZZTNOVL;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event PostUpdateEvent PYZTZTMJEGP;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event PreRenderUpdateEvent KLALXGVBYQI;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event LatePreRenderUpdateEvent RBCIKHNEJYY;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RigidbodyExLateUpdateEvent ERAJCFQAUEL;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event PostNetworkReceiveEvent EJEWJVUTECJ;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event EndOfFrameEvent IVIPBAJEUEN;
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
		[Cpp2IlInjected.Address(RVA = "0x9563E90", Offset = "0x9562A90", VA = "0x189563E90")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9563F90", Offset = "0x9562B90", VA = "0x189563F90")]
		public static void SafeDestroyGameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
		public ApplicationQuitBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class SHXIMBTSZPH
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static bool QREPJRXTHFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9564110", Offset = "0x9562D10", VA = "0x189564110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9564150", Offset = "0x9562D50", VA = "0x189564150")]
		[RRRuntimeInitializeMethod.AfterSceneLoad]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9564200", Offset = "0x9562E00", VA = "0x189564200")]
		internal static void QXPTSKNDMXQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface NFLMYUHPYSI
	{
		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<bool> XUZVRRKEPVI;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetInnerFocusProvider(NFLMYUHPYSI innerProvider);
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
