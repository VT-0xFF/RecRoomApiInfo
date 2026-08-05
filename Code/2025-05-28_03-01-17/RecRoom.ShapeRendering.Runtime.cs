using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.ClusterLODs;
using RecRoom.Configs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88B10A0", Offset = "0x88AFEA0", VA = "0x1888B10A0", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88B3090", Offset = "0x88B1E90", VA = "0x1888B3090", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BHJBMGJGEPD : EKFOOOGMAAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte EJNFAMEGEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] LKGOHMIGOBC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EKEPKJACPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LMPLHJDEPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD521D0", Offset = "0xD50FD0", VA = "0x180D521D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF5E9F0", Offset = "0xF5D7F0", VA = "0x180F5E9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float CBNPDCCJAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF68540", Offset = "0xF67340", VA = "0x180F68540", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1339E40", Offset = "0x1338C40", VA = "0x181339E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CEBIFFNCNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC77D90", Offset = "0xC76B90", VA = "0x180C77D90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC77DA0", Offset = "0xC76BA0", VA = "0x180C77DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> DHHJJPICILF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88A0B60", Offset = "0x889F960", VA = "0x1888A0B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> NMIJGCOIIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88A0710", Offset = "0x889F510", VA = "0x1888A0710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject NLFMPGFBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte BLEEACNOKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88A09B0", Offset = "0x889F7B0", VA = "0x1888A09B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x88A0BB0", Offset = "0x889F9B0", VA = "0x1888A0BB0")]
	public BHJBMGJGEPD(List<AEBBPOAKBMK> JCEGPNEOGDO, List<AEBBPOAKBMK> KOOPHKPGKKB, List<GNLCMFNGHKL> KNEFLMDDNHM, Material EFCBJICGDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x88A0890", Offset = "0x889F690", VA = "0x1888A0890")]
	private int MDLEDDPPGDF(List<AEBBPOAKBMK> LPILIBFAFBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x88A0A00", Offset = "0x889F800", VA = "0x1888A0A00")]
	private void OMGAMJPMFKO(int CPDLFBBEOEJ, bool DLKFMHELCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x88A0740", Offset = "0x889F540", VA = "0x1888A0740")]
	public void KLHKHEIBKII(Vector3 PNAGGHNILKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x88A05D0", Offset = "0x889F3D0", VA = "0x1888A05D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x88A06D0", Offset = "0x889F4D0", VA = "0x1888A06D0")]
	public void EGANPJAGIGD(Transform LICOIELOJPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EGADJAPLFHL : EIOFPFHCGMG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class BIONKDBKENB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EGADJAPLFHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public BIONKDBKENB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88A15D0", Offset = "0x88A03D0", VA = "0x1888A15D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88A0F70", Offset = "0x889FD70", VA = "0x1888A0F70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88A1480", Offset = "0x88A0280", VA = "0x1888A1480")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88A0F20", Offset = "0x889FD20", VA = "0x1888A0F20")]
		private void IMLDEFFNBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88A0ED0", Offset = "0x889FCD0", VA = "0x1888A0ED0")]
		private void AABJPMEACCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88A1580", Offset = "0x88A0380", VA = "0x1888A1580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88A14D0", Offset = "0x88A02D0", VA = "0x1888A14D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88A14D0", Offset = "0x88A02D0", VA = "0x1888A14D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MGCGGKAGAIH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EGADJAPLFHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public MGCGGKAGAIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88B1680", Offset = "0x88B0480", VA = "0x1888B1680", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88B11C0", Offset = "0x88AFFC0", VA = "0x1888B11C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x88B1530", Offset = "0x88B0330", VA = "0x1888B1530")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88B1170", Offset = "0x88AFF70", VA = "0x1888B1170")]
		private void IMLDEFFNBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88B1630", Offset = "0x88B0430", VA = "0x1888B1630", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88B1580", Offset = "0x88B0380", VA = "0x1888B1580", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88B1580", Offset = "0x88B0380", VA = "0x1888B1580", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HFMBOPLHMPF IHBAHMJHKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<ABDJEEJPBNB> IJGBPGICNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> EPNIFOLKJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer GCMAKEFEJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool IBFNCHFNGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool GMPHPGDIOOD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<GAHBFAGALGI> AIOCIACBNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KABNDJHODIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88A4150", Offset = "0x88A2F50", VA = "0x1888A4150", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GNLCMFNGHKL HAJGOJCCGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88A4D30", Offset = "0x88A3B30", VA = "0x1888A4D30", Slot = "8")]
		get
		{
			return default(GNLCMFNGHKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> BHODIPKEPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x88A4D10", Offset = "0x88A3B10", VA = "0x1888A4D10")]
	private bool OOLCPIDNIEO(ABDJEEJPBNB HMDNNMIJNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x88A49B0", Offset = "0x88A37B0", VA = "0x1888A49B0")]
	private static bool JMCNJLBDMIE(ABDJEEJPBNB HMDNNMIJNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x88A4E00", Offset = "0x88A3C00", VA = "0x1888A4E00")]
	public EGADJAPLFHL(HFMBOPLHMPF FFEMKICJPKP, bool HHIPKNHMKOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x88A3CF0", Offset = "0x88A2AF0", VA = "0x1888A3CF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x88A3480", Offset = "0x88A2280", VA = "0x1888A3480")]
	public void AIKICPLLADB(ABDJEEJPBNB HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x88A4190", Offset = "0x88A2F90", VA = "0x1888A4190")]
	public void FKCGDELNEED(ABDJEEJPBNB HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x88A3730", Offset = "0x88A2530", VA = "0x1888A3730", Slot = "4")]
	public void CMPBGAACMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x88A49D0", Offset = "0x88A37D0", VA = "0x1888A49D0")]
	public void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x88A3EE0", Offset = "0x88A2CE0", VA = "0x1888A3EE0")]
	private void EEHDPKDOILB(List<ABDJEEJPBNB> IJGBPGICNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x88A3650", Offset = "0x88A2450", VA = "0x1888A3650")]
	private static Material ANLAOKABJML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88A40A0", Offset = "0x88A2EA0", VA = "0x1888A40A0")]
	private void EEHDPKDOILB(ABDJEEJPBNB HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x88A4C40", Offset = "0x88A3A40", VA = "0x1888A4C40")]
	private void KJLCOAAEGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x88A4370", Offset = "0x88A3170", VA = "0x1888A4370")]
	public void GPLBJINFNHG(bool FNICOICMLPO, bool KCCONJAEFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x88A3C30", Offset = "0x88A2A30", VA = "0x1888A3C30")]
	protected void DKKCEEDEAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x88A42F0", Offset = "0x88A30F0", VA = "0x1888A42F0")]
	public void GPJCIHMOMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x88A4930", Offset = "0x88A3730", VA = "0x1888A4930")]
	[IteratorStateMachine(typeof(BIONKDBKENB))]
	public IEnumerable<Renderer> JBKALHCFMPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x88A36B0", Offset = "0x88A24B0", VA = "0x1888A36B0")]
	[IteratorStateMachine(typeof(MGCGGKAGAIH))]
	public IEnumerable<Renderer> BOJHJNFFEBF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class JCJJPCDIILJ : ABDJEEJPBNB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct CNCEBLMGEFK : NNDANPFBPIA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NONOJJJJOHD JIEGCDEFFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle JAAMMEMKHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OILOIICGDLG JBDKOFJMKBE;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88A33D0", Offset = "0x88A21D0", VA = "0x1888A33D0")]
		public CNCEBLMGEFK(NONOJJJJOHD JIEGCDEFFGO, JobHandle JAAMMEMKHCH, OILOIICGDLG JBDKOFJMKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88A33A0", Offset = "0x88A21A0", VA = "0x1888A33A0", Slot = "4")]
		public NONOJJJJOHD LJHGHGHDHHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x88A3350", Offset = "0x88A2150", VA = "0x1888A3350", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly FLPJCOCICAD KJIKPAONJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float IACBCGEIKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 FFMMPAFIOMB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 JOEFFBLOLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88AB860", Offset = "0x88AA660", VA = "0x1888AB860", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x88ABB60", Offset = "0x88AA960", VA = "0x1888ABB60")]
	public JCJJPCDIILJ(EGADJAPLFHL IPCOMOHMNHK, FLPJCOCICAD FFEMKICJPKP, bool HHIPKNHMKOD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "18")]
	public override bool HICGNNPDDAH(GNLCMFNGHKL IPCOMOHMNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x88AB990", Offset = "0x88AA790", VA = "0x1888AB990", Slot = "19")]
	public override int MDLEDDPPGDF(PBEPDBDEIBA JGJKFDFMJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x88AADF0", Offset = "0x88A9BF0", VA = "0x1888AADF0", Slot = "20")]
	public override int FCPCHKPKODK(PBEPDBDEIBA JGJKFDFMJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x88AA7F0", Offset = "0x88A95F0", VA = "0x1888AA7F0", Slot = "21")]
	public override GEDLKILBCJI DMFGHHEAJPK()
	{
		return default(GEDLKILBCJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC3DD60", Offset = "0xC3CB60", VA = "0x180C3DD60", Slot = "22")]
	public override float IHFMEAAKNIB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x88AA1F0", Offset = "0x88A8FF0", VA = "0x1888AA1F0", Slot = "23")]
	public override void DIPBAGDCPJE(PBEPDBDEIBA JGJKFDFMJDO, AOEBHBIJBCB JFAEDAJNLMJ, int FMHBCCCILMO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x88AB790", Offset = "0x88AA590", VA = "0x1888AB790", Slot = "24")]
	public override GNLCMFNGHKL JPNBFBPMBOO()
	{
		return default(GNLCMFNGHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x88AAC30", Offset = "0x88A9A30", VA = "0x1888AAC30", Slot = "26")]
	public override CGFGEAGOPNL FAHCHFELKPD()
	{
		return default(CGFGEAGOPNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x88AAFC0", Offset = "0x88A9DC0", VA = "0x1888AAFC0", Slot = "27")]
	public override NNDANPFBPIA JPEGHJOHNNP(PBEPDBDEIBA JGJKFDFMJDO, JobHandle JAAMMEMKHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface CPCCMDHOAHC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EGADJAPLFHL ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ABDJEEJPBNB ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LGDNOOHOBMI ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class ILKDOENNGCE : NBGHGFAEDDJ, IDisposable, CPCCMDHOAHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KEIBDBOGOPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ILKDOENNGCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x88AE5C0", Offset = "0x88AD3C0", VA = "0x1888AE5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x88AEB40", Offset = "0x88AD940", VA = "0x1888AEB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GOKPNNDFHDE<BLHOJKOBONC, EGADJAPLFHL> IBFEJMJCEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly GOKPNNDFHDE<FANFIOCPJIG, ABDJEEJPBNB> IJGBPGICNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly GOKPNNDFHDE<NHKMHBFHALC, LGDNOOHOBMI> JNFDLIDOOAP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EGADJAPLFHL ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x88A9150", Offset = "0x88A7F50", VA = "0x1888A9150", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ABDJEEJPBNB ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x88A90F0", Offset = "0x88A7EF0", VA = "0x1888A90F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LGDNOOHOBMI ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x88A91B0", Offset = "0x88A7FB0", VA = "0x1888A91B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool EPHAMJLKPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7700", VA = "0x180AD8900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x88A9D40", Offset = "0x88A8B40", VA = "0x1888A9D40")]
	public ILKDOENNGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x88A8AD0", Offset = "0x88A78D0", VA = "0x1888A8AD0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x88A9D30", Offset = "0x88A8B30", VA = "0x1888A9D30", Slot = "4")]
	public BLHOJKOBONC MPLMOFIKBNL(HFMBOPLHMPF FFEMKICJPKP)
	{
		return default(BLHOJKOBONC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x88A9AB0", Offset = "0x88A88B0", VA = "0x1888A9AB0", Slot = "5")]
	public BLHOJKOBONC MPLMOFIKBNL(HFMBOPLHMPF FFEMKICJPKP, bool HHIPKNHMKOD)
	{
		return default(BLHOJKOBONC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x88A8870", Offset = "0x88A7670", VA = "0x1888A8870", Slot = "6")]
	public void DLCFNNEDOMD(BLHOJKOBONC IPCOMOHMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x88A80D0", Offset = "0x88A6ED0", VA = "0x1888A80D0", Slot = "7")]
	public void CCCNNFGLLKJ(BLHOJKOBONC IPCOMOHMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x88A7BF0", Offset = "0x88A69F0", VA = "0x1888A7BF0", Slot = "8")]
	public FANFIOCPJIG APBBHGOLELJ(BLHOJKOBONC IPCOMOHMNHK, EPJPNHNLMPC FFEMKICJPKP)
	{
		return default(FANFIOCPJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x88A95D0", Offset = "0x88A83D0", VA = "0x1888A95D0", Slot = "9")]
	public FANFIOCPJIG LHNJBODKCCO(BLHOJKOBONC IPCOMOHMNHK, FLPJCOCICAD FFEMKICJPKP)
	{
		return default(FANFIOCPJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x88A84B0", Offset = "0x88A72B0", VA = "0x1888A84B0", Slot = "11")]
	public void DBNFJNBLIOG(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x88A9300", Offset = "0x88A8100", VA = "0x1888A9300", Slot = "10")]
	public void KLGLCHMBIHA(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x88A7B80", Offset = "0x88A6980", VA = "0x1888A7B80", Slot = "20")]
	public IEnumerable<Renderer> AJLHHKJGDHO(BLHOJKOBONC IPCOMOHMNHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x88A8430", Offset = "0x88A7230", VA = "0x1888A8430", Slot = "12")]
	public NHKMHBFHALC CLGCKKIAJNM(JLNFEINOIPI FFEMKICJPKP)
	{
		return default(NHKMHBFHALC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x88A9560", Offset = "0x88A8360", VA = "0x1888A9560", Slot = "14")]
	public void LCMNJFFDKIC(NHKMHBFHALC DNFLEEIEPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x88A8F30", Offset = "0x88A7D30", VA = "0x1888A8F30", Slot = "16")]
	public Task FHBGKNKGDLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x88A8D70", Offset = "0x88A7B70", VA = "0x1888A8D70", Slot = "17")]
	public Task FFFELJIKHAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x88A8CA0", Offset = "0x88A7AA0", VA = "0x1888A8CA0", Slot = "18")]
	[AsyncStateMachine(typeof(KEIBDBOGOPB))]
	public Task FBLHIDCDMFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x88A9210", Offset = "0x88A8010", VA = "0x1888A9210", Slot = "19")]
	public void IIPICOCAPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x88A7B20", Offset = "0x88A6920", VA = "0x1888A7B20", Slot = "13")]
	public void ABPMIKJPJIJ(NHKMHBFHALC DNFLEEIEPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class GNIOLMEEJGH : ABDJEEJPBNB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct FBFNGKCFJPC : NNDANPFBPIA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private NONOJJJJOHD JIEGCDEFFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> JKKGGGJBCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle JAAMMEMKHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private FOMCKKHJCPF JBDKOFJMKBE;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x88A4FF0", Offset = "0x88A3DF0", VA = "0x1888A4FF0")]
		public FBFNGKCFJPC(NONOJJJJOHD JIEGCDEFFGO, NativeArray<int> JKKGGGJBCGN, JobHandle JAAMMEMKHCH, FOMCKKHJCPF JBDKOFJMKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x88A4F90", Offset = "0x88A3D90", VA = "0x1888A4F90", Slot = "4")]
		public NONOJJJJOHD LJHGHGHDHHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x88A4EF0", Offset = "0x88A3CF0", VA = "0x1888A4EF0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly EPJPNHNLMPC NOKLNLDMACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] APFGJPOHDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 FFMMPAFIOMB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 EHFOFKKMABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x88A6370", Offset = "0x88A5170", VA = "0x1888A6370")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 JOEFFBLOLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x88A7290", Offset = "0x88A6090", VA = "0x1888A7290", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x88A7470", Offset = "0x88A6270", VA = "0x1888A7470")]
	public GNIOLMEEJGH(EGADJAPLFHL IPCOMOHMNHK, EPJPNHNLMPC FFEMKICJPKP, bool AEKMHLJCJIA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x88A6820", Offset = "0x88A5620", VA = "0x1888A6820", Slot = "18")]
	public override bool HICGNNPDDAH(GNLCMFNGHKL IPCOMOHMNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x88A5AB0", Offset = "0x88A48B0", VA = "0x1888A5AB0", Slot = "21")]
	public override GEDLKILBCJI DMFGHHEAJPK()
	{
		return default(GEDLKILBCJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x88A5AF0", Offset = "0x88A48F0", VA = "0x1888A5AF0")]
	private GEDLKILBCJI DMFGHHEAJPK(GNLCMFNGHKL IPCOMOHMNHK)
	{
		return default(GEDLKILBCJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x88A5050", Offset = "0x88A3E50", VA = "0x1888A5050")]
	private HPHGBMKCHHO AEKBBJJJOEA([In] UniformTRS GJGIGHHPPND, [In] float3 JAFEPDOMLEC)
	{
		return default(HPHGBMKCHHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x88A73C0", Offset = "0x88A61C0", VA = "0x1888A73C0", Slot = "19")]
	public override int MDLEDDPPGDF(PBEPDBDEIBA JGJKFDFMJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x88A62C0", Offset = "0x88A50C0", VA = "0x1888A62C0", Slot = "20")]
	public override int FCPCHKPKODK(PBEPDBDEIBA JGJKFDFMJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x88A68F0", Offset = "0x88A56F0", VA = "0x1888A68F0", Slot = "22")]
	public override float IHFMEAAKNIB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x88A65A0", Offset = "0x88A53A0", VA = "0x1888A65A0")]
	private int GIIPKLMBHEH(PBEPDBDEIBA JGJKFDFMJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x88A5250", Offset = "0x88A4050", VA = "0x1888A5250", Slot = "23")]
	public override void DIPBAGDCPJE(PBEPDBDEIBA JGJKFDFMJDO, AOEBHBIJBCB JFAEDAJNLMJ, int FMHBCCCILMO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x88A71C0", Offset = "0x88A5FC0", VA = "0x1888A71C0", Slot = "24")]
	public override GNLCMFNGHKL JPNBFBPMBOO()
	{
		return default(GNLCMFNGHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x88A6100", Offset = "0x88A4F00", VA = "0x1888A6100", Slot = "26")]
	public override CGFGEAGOPNL FAHCHFELKPD()
	{
		return default(CGFGEAGOPNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x88A69E0", Offset = "0x88A57E0", VA = "0x1888A69E0", Slot = "27")]
	public override NNDANPFBPIA JPEGHJOHNNP(PBEPDBDEIBA JGJKFDFMJDO, JobHandle JAAMMEMKHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AMDOLPMKOPD
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEFLNHIGLMI(BBFHFFOIEKE AAFMBEEMJAC, Renderer NHLDFAAJMGK, int KALEBIBDIGK);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHFKELNNLDL(Renderer NHLDFAAJMGK, KIEKGGPMJIE ALNLEONPBLH, Vector3 EJDCLBEPIIF, Vector3 FPEBAKKCMKF, Vector3 FDFEMBFABEA, float MDBLJGPKLGO, float JDKANEIJCPG, float DNJPJECCJBH = -1f, [Optional] Color? DEJLIDMJHPI, [Optional] IReadOnlyList<Camera> ONJLOPCHMGD);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOOGOFHBEJG(Renderer NHLDFAAJMGK, int KALEBIBDIGK);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JCGNAOKLEDA();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLCHHDOBGBH(int OHDMDIDDFGO, MNEOPFCLMIK AAFMBEEMJAC, Renderer NHLDFAAJMGK, int KALEBIBDIGK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JDGEPLKFGKO : GDJLPLLNOFP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class DMBPNKEBBHP : ELIMNJENEJG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x88A3430", Offset = "0x88A2230", VA = "0x1888A3430")]
		public DMBPNKEBBHP(string IHGFMOMOADA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly AMDOLPMKOPD IONIINNECEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CPCCMDHOAHC CFNIOBCIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer OAKLHEOIEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private DMBPNKEBBHP BCGGLHKLMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool LEGOEHDOAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer LEONIDGJGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private DMBPNKEBBHP GCBKJAAJKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool OCKEMABPDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer ALDMECPDBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private DMBPNKEBBHP GODINNNFAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool KICJICEPMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public JDGEPLKFGKO(AMDOLPMKOPD PGHEJOMPKCP, CPCCMDHOAHC CFNIOBCIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x88ACAD0", Offset = "0x88AB8D0", VA = "0x1888ACAD0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x88AC480", Offset = "0x88AB280", VA = "0x1888AC480")]
	private void BLFFPJEPPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x88AE2B0", Offset = "0x88AD0B0", VA = "0x1888AE2B0", Slot = "4")]
	public void PIFCCANFDME(BLHOJKOBONC IPCOMOHMNHK, MNEOPFCLMIK IBFIHEMIHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x88AE090", Offset = "0x88ACE90", VA = "0x1888AE090", Slot = "5")]
	public void PIFCCANFDME(FANFIOCPJIG HMDNNMIJNJJ, MNEOPFCLMIK IBFIHEMIHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x88ADBF0", Offset = "0x88AC9F0", VA = "0x1888ADBF0", Slot = "6")]
	public void JIIKFJACJOE(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x88ADD50", Offset = "0x88ACB50", VA = "0x1888ADD50", Slot = "7")]
	public void JMHBLAAODJE(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x88ACA90", Offset = "0x88AB890", VA = "0x1888ACA90", Slot = "24")]
	public void DEIIBOEDPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x10DF6D0", Offset = "0x10DE4D0", VA = "0x1810DF6D0", Slot = "8")]
	public void KPIGFAICOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x88ACC80", Offset = "0x88ABA80", VA = "0x1888ACC80", Slot = "9")]
	public void ENINGCEJIDA(MNEOPFCLMIK IBFIHEMIHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x88AD5B0", Offset = "0x88AC3B0", VA = "0x1888AD5B0", Slot = "10")]
	public void JGNAHCEEKJL(BLHOJKOBONC IPCOMOHMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x88AD890", Offset = "0x88AC690", VA = "0x1888AD890", Slot = "11")]
	public void JGNAHCEEKJL(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x88ADFC0", Offset = "0x88ACDC0", VA = "0x1888ADFC0", Slot = "12")]
	public void OMBLNFFMLEH(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x88AD4E0", Offset = "0x88AC2E0", VA = "0x1888AD4E0", Slot = "13")]
	public void JFPIAMGCFMO(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x88AD1A0", Offset = "0x88ABFA0", VA = "0x1888AD1A0")]
	private void HBMJMOANGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x136EC40", Offset = "0x136DA40", VA = "0x18136EC40", Slot = "14")]
	public void AONFEHOGFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x88ADEA0", Offset = "0x88ACCA0", VA = "0x1888ADEA0", Slot = "15")]
	public void KCFOJBPIFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x88ACEC0", Offset = "0x88ABCC0", VA = "0x1888ACEC0", Slot = "16")]
	public void FHFHKEDINLC(BLHOJKOBONC IPCOMOHMNHK, BBFHFFOIEKE AAFMBEEMJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x88ACDF0", Offset = "0x88ABBF0", VA = "0x1888ACDF0", Slot = "17")]
	public void FEOOJHIAHEN(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x88AD410", Offset = "0x88AC210", VA = "0x1888AD410", Slot = "18")]
	public void ICLLDDEFFGI(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xCB89A0", Offset = "0xCB77A0", VA = "0x180CB89A0", Slot = "19")]
	public void LGAPJMJPFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x88AC6F0", Offset = "0x88AB4F0", VA = "0x1888AC6F0", Slot = "20")]
	public void CBONONFPGKI(BBFHFFOIEKE AAFMBEEMJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x88AC820", Offset = "0x88AB620", VA = "0x1888AC820")]
	private void CIKONFJJGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x88ABC10", Offset = "0x88AAA10", VA = "0x1888ABC10", Slot = "21")]
	public void BHHGONCGIBP(BLHOJKOBONC IPCOMOHMNHK, Vector3 EJDCLBEPIIF, Vector3 FPEBAKKCMKF, Vector3 FDFEMBFABEA, float MDBLJGPKLGO, float JDKANEIJCPG, IReadOnlyList<Camera> NFMPFCNFPIM, KIEKGGPMJIE ALNLEONPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x88ABFE0", Offset = "0x88AADE0", VA = "0x1888ABFE0", Slot = "22")]
	public void BHHGONCGIBP(NHKMHBFHALC DNFLEEIEPFC, Vector3 EJDCLBEPIIF, Vector3 FPEBAKKCMKF, Vector3 FDFEMBFABEA, float MDBLJGPKLGO, float JDKANEIJCPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ABDJEEJPBNB : GCACBHBPDKI, GAHBFAGALGI, PBCCJMFJEHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly EGADJAPLFHL NLFMPGFBLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int LHOGLADNHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds OKIGFLMKFMG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds GOGCLEPDBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x889F240", Offset = "0x889E040", VA = "0x18889F240", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool GMPHPGDIOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD9C6A0", Offset = "0xD9B4A0", VA = "0x180D9C6A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD9C6B0", Offset = "0xD9B4B0", VA = "0x180D9C6B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 JOEFFBLOLKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HMGKBHKHHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xBFF4C0", Offset = "0xBFE2C0", VA = "0x180BFF4C0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public LPMDJIPAODH GLFIJDBBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PMAPOGADCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xEC4340", Offset = "0xEC3140", VA = "0x180EC4340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	protected ABDJEEJPBNB(EGADJAPLFHL IPCOMOHMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x889F0A0", Offset = "0x889DEA0", VA = "0x18889F0A0", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "18")]
	public virtual bool HICGNNPDDAH(GNLCMFNGHKL IPCOMOHMNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x889F290", Offset = "0x889E090", VA = "0x18889F290", Slot = "10")]
	public int HDDANLCIAPC(int BNIFDEOHMGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int MDLEDDPPGDF(PBEPDBDEIBA JGJKFDFMJDO);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int FCPCHKPKODK(PBEPDBDEIBA JGJKFDFMJDO);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract GEDLKILBCJI DMFGHHEAJPK();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float IHFMEAAKNIB();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void DIPBAGDCPJE(PBEPDBDEIBA JGJKFDFMJDO, AOEBHBIJBCB JFAEDAJNLMJ, int FMHBCCCILMO = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract GNLCMFNGHKL JPNBFBPMBOO();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x889F260", Offset = "0x889E060", VA = "0x18889F260", Slot = "13")]
	public Hash128 FPLNJDHGCMG(int JGJKFDFMJDO)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract CGFGEAGOPNL FAHCHFELKPD();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract NNDANPFBPIA JPEGHJOHNNP(PBEPDBDEIBA JGJKFDFMJDO, JobHandle JAAMMEMKHCH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x889F210", Offset = "0x889E010", VA = "0x18889F210", Slot = "12")]
	public NNDANPFBPIA EGJNNAJPIOO(int JGJKFDFMJDO)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x88B1BE0", Offset = "0x88B09E0", VA = "0x1888B1BE0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CMEFFHAEBID
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LCGCPKNKCAB : IEnumerable<ONJNMFJJCNA>, IEnumerable, IEnumerator<ONJNMFJJCNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private ONJNMFJJCNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private ONJNMFJJCNA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public LCGCPKNKCAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x88AEBA0", Offset = "0x88AD9A0", VA = "0x1888AEBA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x88AED10", Offset = "0x88ADB10", VA = "0x1888AED10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x88AEC70", Offset = "0x88ADA70", VA = "0x1888AEC70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ONJNMFJJCNA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x88AEC70", Offset = "0x88ADA70", VA = "0x1888AEC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ONJNMFJJCNA[][] HPMJIDCCPDC;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static DKMDJENKPNF GPIDBNPMLDD;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig MPFLDCHPNHO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader GMIHBNPLFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x88A2C10", Offset = "0x88A1A10", VA = "0x1888A2C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer LOFGMHFKCPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x88A2D60", Offset = "0x88A1B60", VA = "0x1888A2D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x88A2C70", Offset = "0x88A1A70", VA = "0x1888A2C70")]
	[EKIJCKMDHHI]
	internal static void IANLJFINMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x88A2DD0", Offset = "0x88A1BD0", VA = "0x1888A2DD0")]
	public static Mesh MEKEAALJDHE(JBBAGKFDBNF NEKJIAJELGG, int JGJKFDFMJDO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x88A2DC0", Offset = "0x88A1BC0", VA = "0x1888A2DC0")]
	public static int LIHGHPBKCCM(JBBAGKFDBNF NEKJIAJELGG, int JGJKFDFMJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x88A2970", Offset = "0x88A1770", VA = "0x1888A2970")]
	public static DKMDJENKPNF FJIJFBGBICB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x88A2BB0", Offset = "0x88A19B0", VA = "0x1888A2BB0")]
	[IteratorStateMachine(typeof(LCGCPKNKCAB))]
	private static IEnumerable<ONJNMFJJCNA> GJFHGGJEPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x88A17C0", Offset = "0x88A05C0", VA = "0x1888A17C0")]
	public static ONJNMFJJCNA CNLFOLBHIIN(JBBAGKFDBNF NEKJIAJELGG, int JGJKFDFMJDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x88A2B90", Offset = "0x88A1990", VA = "0x1888A2B90")]
	public static bool GHLPKHBDOHG(this JBBAGKFDBNF NEKJIAJELGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x88A25E0", Offset = "0x88A13E0", VA = "0x1888A25E0")]
	public static void DBJNGDHMNBN(JBBAGKFDBNF NEKJIAJELGG, float3 OBGMLCBDIOD, [Out] MICJMPBPOBO LGBIGFJLFNB, [Out] float3 AMNICELJDJC, [Out] float CJHJODOIFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x88A2E70", Offset = "0x88A1C70", VA = "0x1888A2E70")]
	public static void NDJOLOPHKGL(Vector3 OBGMLCBDIOD, JBBAGKFDBNF NEKJIAJELGG, [Out] Vector3 AMNICELJDJC, [Out] float CJHJODOIFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x88A3240", Offset = "0x88A2040", VA = "0x1888A3240")]
	[OPAKMIDKBOD(0)]
	[OHEKCAPHOOO(LHBMPOBGEAI.ExitingPlayMode, 0)]
	private static void OBBEAEKEDJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x88A2790", Offset = "0x88A1590", VA = "0x1888A2790")]
	[OPAKMIDKBOD(0)]
	[OHEKCAPHOOO(LHBMPOBGEAI.ExitingPlayMode, 0)]
	private static void DGPBOMBOEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class LJDGKHLEPAH : NBGHGFAEDDJ, IDisposable, CPCCMDHOAHC
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly GOKPNNDFHDE<BLHOJKOBONC, EGADJAPLFHL> IBFEJMJCEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly GOKPNNDFHDE<FANFIOCPJIG, ABDJEEJPBNB> IJGBPGICNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly GOKPNNDFHDE<NHKMHBFHALC, LGDNOOHOBMI> JNFDLIDOOAP;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public EGADJAPLFHL ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x88B08B0", Offset = "0x88AF6B0", VA = "0x1888B08B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ABDJEEJPBNB ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x88B0850", Offset = "0x88AF650", VA = "0x1888B0850", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public LGDNOOHOBMI ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x88B0910", Offset = "0x88AF710", VA = "0x1888B0910", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool EPHAMJLKPII
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7700", VA = "0x180AD8900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x88B0CB0", Offset = "0x88AFAB0", VA = "0x1888B0CB0")]
	public LJDGKHLEPAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x88B05E0", Offset = "0x88AF3E0", VA = "0x1888B05E0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x88B0B80", Offset = "0x88AF980", VA = "0x1888B0B80", Slot = "4")]
	public BLHOJKOBONC MPLMOFIKBNL(HFMBOPLHMPF FFEMKICJPKP)
	{
		return default(BLHOJKOBONC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x88B0B80", Offset = "0x88AF980", VA = "0x1888B0B80", Slot = "5")]
	public BLHOJKOBONC MPLMOFIKBNL(HFMBOPLHMPF FFEMKICJPKP, bool HHIPKNHMKOD)
	{
		return default(BLHOJKOBONC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x88B0580", Offset = "0x88AF380", VA = "0x1888B0580", Slot = "6")]
	public void DLCFNNEDOMD(BLHOJKOBONC IPCOMOHMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x88B03F0", Offset = "0x88AF1F0", VA = "0x1888B03F0", Slot = "7")]
	public void CCCNNFGLLKJ(BLHOJKOBONC IPCOMOHMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x88B02B0", Offset = "0x88AF0B0", VA = "0x1888B02B0", Slot = "8")]
	public FANFIOCPJIG APBBHGOLELJ(BLHOJKOBONC IPCOMOHMNHK, EPJPNHNLMPC FFEMKICJPKP)
	{
		return default(FANFIOCPJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x88B0A40", Offset = "0x88AF840", VA = "0x1888B0A40", Slot = "9")]
	public FANFIOCPJIG LHNJBODKCCO(BLHOJKOBONC IPCOMOHMNHK, FLPJCOCICAD FFEMKICJPKP)
	{
		return default(FANFIOCPJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x88B04F0", Offset = "0x88AF2F0", VA = "0x1888B04F0", Slot = "11")]
	public void DBNFJNBLIOG(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x88B0970", Offset = "0x88AF770", VA = "0x1888B0970", Slot = "10")]
	public void KLGLCHMBIHA(FANFIOCPJIG HMDNNMIJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x88B0240", Offset = "0x88AF040", VA = "0x1888B0240", Slot = "20")]
	public IEnumerable<Renderer> AJLHHKJGDHO(BLHOJKOBONC IPCOMOHMNHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x88B0470", Offset = "0x88AF270", VA = "0x1888B0470", Slot = "12")]
	public NHKMHBFHALC CLGCKKIAJNM(JLNFEINOIPI FFEMKICJPKP)
	{
		return default(NHKMHBFHALC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x88B09D0", Offset = "0x88AF7D0", VA = "0x1888B09D0", Slot = "14")]
	public void LCMNJFFDKIC(NHKMHBFHALC DNFLEEIEPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x88B07B0", Offset = "0x88AF5B0", VA = "0x1888B07B0", Slot = "16")]
	public Task FHBGKNKGDLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x88B0710", Offset = "0x88AF510", VA = "0x1888B0710", Slot = "17")]
	public Task FFFELJIKHAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x88B0670", Offset = "0x88AF470", VA = "0x1888B0670", Slot = "18")]
	public Task FBLHIDCDMFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2703050", Offset = "0x2701E50", VA = "0x182703050", Slot = "19")]
	public void IIPICOCAPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x88B01E0", Offset = "0x88AEFE0", VA = "0x1888B01E0", Slot = "13")]
	public void ABPMIKJPJIJ(NHKMHBFHALC DNFLEEIEPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IMDBICNOLDD
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CMMLFEBNGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material NADJODECBHI();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material ANLAOKABJML();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material EBFGCHNFBLK();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PDMPLMENNOC(FLGDJDIBGKI CKEOIJBAIFI);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MPBHNJANHEC(BDLOEKFKAIO NLAGIFCIIIE);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MIKHODHGKCH(GameObject GLEBGNJJOHG);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KNLBPFKNFJG(GameObject GLEBGNJJOHG, bool NBLKCLKKLKA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PFFCIAPFHFE
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static IMDBICNOLDD OMKBHAHHOCG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool CMMLFEBNGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x88B17B0", Offset = "0x88B05B0", VA = "0x1888B17B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x88B1B10", Offset = "0x88B0910", VA = "0x1888B1B10")]
	public static void OFBJNJLINPP(IMDBICNOLDD KGEBELIJBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x88B1AB0", Offset = "0x88B08B0", VA = "0x1888B1AB0")]
	public static Material NADJODECBHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x88A3650", Offset = "0x88A2450", VA = "0x1888A3650")]
	public static Material ANLAOKABJML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x88B1810", Offset = "0x88B0610", VA = "0x1888B1810")]
	public static Material EBFGCHNFBLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x88B1B70", Offset = "0x88B0970", VA = "0x1888B1B70")]
	public static int PDMPLMENNOC(FLGDJDIBGKI CKEOIJBAIFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x88B1A40", Offset = "0x88B0840", VA = "0x1888B1A40")]
	public static int MPBHNJANHEC(BDLOEKFKAIO NLAGIFCIIIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x88B1960", Offset = "0x88B0760", VA = "0x1888B1960")]
	public static void MIKHODHGKCH(GameObject GLEBGNJJOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x88B1870", Offset = "0x88B0670", VA = "0x1888B1870")]
	public static void KNLBPFKNFJG(GameObject GLEBGNJJOHG, bool NBLKCLKKLKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LGDNOOHOBMI : EIOFPFHCGMG
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HKKNFGHNMEC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LGDNOOHOBMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public HKKNFGHNMEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x88A7A90", Offset = "0x88A6890", VA = "0x1888A7A90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x88A7720", Offset = "0x88A6520", VA = "0x1888A7720", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x88A7940", Offset = "0x88A6740", VA = "0x1888A7940")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x88A7A40", Offset = "0x88A6840", VA = "0x1888A7A40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x88A7990", Offset = "0x88A6790", VA = "0x1888A7990", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x88A7990", Offset = "0x88A6790", VA = "0x1888A7990", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JLNFEINOIPI KANEJNFDGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CPCCMDHOAHC CFNIOBCIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private BHJBMGJGEPD IGILNCHCPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<AEBBPOAKBMK> FKMKDGNADNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<AEBBPOAKBMK> CKOBHKFGIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject MGHJGANCDHE;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x88AED60", Offset = "0x88ADB60", VA = "0x1888AED60")]
	public static LGDNOOHOBMI BBDJPPAKLHI(JLNFEINOIPI FFEMKICJPKP, CPCCMDHOAHC CFNIOBCIPGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x88B0100", Offset = "0x88AEF00", VA = "0x1888B0100")]
	private LGDNOOHOBMI(JLNFEINOIPI FFEMKICJPKP, CPCCMDHOAHC CFNIOBCIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x88AFC70", Offset = "0x88AEA70", VA = "0x1888AFC70")]
	public void LNJEMOCDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x88AF9A0", Offset = "0x88AE7A0", VA = "0x1888AF9A0")]
	[IteratorStateMachine(typeof(HKKNFGHNMEC))]
	public IEnumerable<Renderer> JBKALHCFMPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x88AEEB0", Offset = "0x88ADCB0", VA = "0x1888AEEB0", Slot = "4")]
	public void CMPBGAACMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x88AF970", Offset = "0x88AE770", VA = "0x1888AF970")]
	private void ENACBEOJIAK(Vector3 PNAGGHNILKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x88AFA20", Offset = "0x88AE820", VA = "0x1888AFA20")]
	public void JPEBABACHJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AEBBPOAKBMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct EBCMNEIPJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AOEBHBIJBCB PBCNIPPOPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GNLCMFNGHKL CDBKCHGLPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int CPMCKCPABNG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HDBMOKBLIJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AEBBPOAKBMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public PBEPDBDEIBA lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<EBCMNEIPJCO> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NONOJJJJOHD combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public HDBMOKBLIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x88A7690", Offset = "0x88A6490", VA = "0x1888A7690")]
		internal JobHandle IOAIKFNLDIN()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x88A76F0", Offset = "0x88A64F0", VA = "0x1888A76F0")]
		internal void POCFKLBDFBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x88A7520", Offset = "0x88A6320", VA = "0x1888A7520")]
		internal void APNGPANIBFE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] NBCEHDPOFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private DJOPIJGIHAP DNBFNBKCMBG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 OADJJPKMPHO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh NCJJOMJEBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GEMKIIKMKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x889F9D0", Offset = "0x889E7D0", VA = "0x18889F9D0")]
	public void EILAGGIJHJG(List<GNLCMFNGHKL> IFNAMPMJCEB, Matrix4x4[] MKCGMAKDCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x889F2A0", Offset = "0x889E0A0", VA = "0x18889F2A0")]
	public static List<AEBBPOAKBMK> BHEMCOAOOEF(List<EGADJAPLFHL> KLACCLHKBGK, PBEPDBDEIBA JGJKFDFMJDO, Bounds ECBLDOPKHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x889FBC0", Offset = "0x889E9C0", VA = "0x18889FBC0")]
	private JobHandle NEFLAPFHOOH(NONOJJJJOHD PMKEHCLADBG, int JDEAPLOGHMI, int JNCGHNJOHFD, PBEPDBDEIBA JGJKFDFMJDO, List<EBCMNEIPJCO> NPKLCNGCEAL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x889FF30", Offset = "0x889ED30", VA = "0x18889FF30")]
	private void PLAAMBNHBNE(List<EBCMNEIPJCO> NPKLCNGCEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x88A01B0", Offset = "0x889EFB0", VA = "0x1888A01B0")]
	private AEBBPOAKBMK(List<EBCMNEIPJCO> NPKLCNGCEAL, int JDEAPLOGHMI, int JNCGHNJOHFD, PBEPDBDEIBA JGJKFDFMJDO, Bounds ECBLDOPKHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x889F930", Offset = "0x889E730", VA = "0x18889F930", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private MaterialPropertyBlock FOLMANNOIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private AEBBPOAKBMK JIEGCDEFFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<GNLCMFNGHKL> KNEFLMDDNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture MKPHGNFHOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer GBFACAPHEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader LMBBLMICBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] IIKMAFALHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int KDEOALJKKMP;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer FMDAMCDMLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int NOELFLGKBPI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x88B2910", Offset = "0x88B1710", VA = "0x1888B2910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x88B1C40", Offset = "0x88B0A40", VA = "0x1888B1C40")]
		public static List<SkinnedShapeRenderer> Create(GameObject IPCOMOHMNHK, List<AEBBPOAKBMK> LPILIBFAFBD, List<GNLCMFNGHKL> KNEFLMDDNHM, Material EFCBJICGDPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x88B2300", Offset = "0x88B1100", VA = "0x1888B2300")]
		public void Init(AEBBPOAKBMK JIEGCDEFFGO, List<GNLCMFNGHKL> KNEFLMDDNHM, Material EFCBJICGDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x88B2870", Offset = "0x88B1670", VA = "0x1888B2870")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x88B27D0", Offset = "0x88B15D0", VA = "0x1888B27D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x88B2790", Offset = "0x88B1590", VA = "0x1888B2790")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x88B2240", Offset = "0x88B1040", VA = "0x1888B2240")]
		private void GPIODALOFNF(ScriptableRenderContext JAPGNGDBBIF, Camera[] DBPOJCJPNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x88B1ED0", Offset = "0x88B0CD0", VA = "0x1888B1ED0")]
		private void EILAGGIJHJG(CommandBuffer HEIPGNLNKGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public SkinnedShapeRenderer()
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
