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
		[Cpp2IlInjected.Address(RVA = "0x96CBD00", Offset = "0x96CA700", VA = "0x1896CBD00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class VSNGMDLUSYQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Thread RZVNPWMMHSE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool ZKWYLWOGOZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x96CBCB0", Offset = "0x96CA6B0", VA = "0x1896CBCB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC50", Offset = "0x96CA650", VA = "0x1896CBC50")]
		[RRRuntimeInitializeMethod]
		internal static void EOQBVPFENUW()
		{
		}
	}
}
namespace RecRoom.ApplicationLifecycle
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface VYJJVLJDUVA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ApplicationFocusEvent UHMQARUQZTN;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event UpdateEvent UENQCAZHILS;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event FixedUpdateEvent WSWQOFSMATO;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event LateUpdateEvent DHJCLUNQAAM;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event PostUpdateEvent CBZIAGZSBFU;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event PreRenderUpdateEvent JPASDREUQAX;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event LatePreRenderUpdateEvent VYXAUFWUNPR;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RigidbodyExLateUpdateEvent KFVNGOTPWYE;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event PostNetworkReceiveEvent DVXHLJYDWCM;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event EndOfFrameEvent VRFOEPVWCEU;
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
		[Cpp2IlInjected.Address(RVA = "0x96CB950", Offset = "0x96CA350", VA = "0x1896CB950")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x96CBA50", Offset = "0x96CA450", VA = "0x1896CBA50")]
		public static void SafeDestroyGameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public ApplicationQuitBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class JRLXUIPADOG
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static bool KEKSOSAQWKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x96CBB20", Offset = "0x96CA520", VA = "0x1896CBB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x96CBB60", Offset = "0x96CA560", VA = "0x1896CBB60")]
		[RRRuntimeInitializeMethod.AfterSceneLoad]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC10", Offset = "0x96CA610", VA = "0x1896CBC10")]
		internal static void NXDDBFHORDR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface CCSBGGOUGTZ
	{
		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<bool> NPAGVDOHZCN;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetInnerFocusProvider(CCSBGGOUGTZ innerProvider);
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
