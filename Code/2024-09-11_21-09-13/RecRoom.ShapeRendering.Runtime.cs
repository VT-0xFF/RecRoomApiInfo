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
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ShapeRendering;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74D9E30", Offset = "0x74D8430", VA = "0x1874D9E30", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HJJBNOPDMKA : MOAMBMMBALK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte IHPIHHNBGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] JEEAMHGBKFO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KCIKJBNFDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F5280", Offset = "0x8F3880", VA = "0x1808F5280", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91F1E0", Offset = "0x91D7E0", VA = "0x18091F1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JOKMOKEKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C59A0", Offset = "0x8C3FA0", VA = "0x1808C59A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C50B0", Offset = "0x8C36B0", VA = "0x1808C50B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float EAHNBEMDIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9253A0", Offset = "0x9239A0", VA = "0x1809253A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB63540", Offset = "0xB61B40", VA = "0x180B63540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CGHEOIKNBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x925390", Offset = "0x923990", VA = "0x180925390", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xFF0680", Offset = "0xFEEC80", VA = "0x180FF0680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> KGCNIGOHDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x74D2A10", Offset = "0x74D1010", VA = "0x1874D2A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> KIPFDCHFAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74D2D10", Offset = "0x74D1310", VA = "0x1874D2D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte FNFDEGAGMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74D2760", Offset = "0x74D0D60", VA = "0x1874D2760", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x74D2D40", Offset = "0x74D1340", VA = "0x1874D2D40")]
	public HJJBNOPDMKA(List<LPKFEFGMLPK> KHFJNACDABB, List<LPKFEFGMLPK> PLIGJCPBJDC, List<OLHIMCMANHM> MEDPHPPCKBJ, Material KFGOIEOLDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74D2A60", Offset = "0x74D1060", VA = "0x1874D2A60")]
	private int GAFHMPPANPN(List<LPKFEFGMLPK> CBLAEIHFGND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74D27B0", Offset = "0x74D0DB0", VA = "0x1874D27B0")]
	private void DAKLMLEOHBD(int DDBJFCFNEDA, bool OPPPLDKFPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x74D2B80", Offset = "0x74D1180", VA = "0x1874D2B80")]
	public void GCNDJDLMOCC(Vector3 PNPNJFAEELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x74D2910", Offset = "0x74D0F10", VA = "0x1874D2910", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x74D2CD0", Offset = "0x74D12D0", VA = "0x1874D2CD0")]
	public void KPHIGCIGGGM(Transform AGIBDIFBHDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NCFCEOBAOLK : COHIMFBCGOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JHFCFHHHPKN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NCFCEOBAOLK <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x965BF0", Offset = "0x9641F0", VA = "0x180965BF0")]
		[DebuggerHidden]
		public JHFCFHHHPKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x74D5600", Offset = "0x74D3C00", VA = "0x1874D5600", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x74D4FF0", Offset = "0x74D35F0", VA = "0x1874D4FF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x74D4FA0", Offset = "0x74D35A0", VA = "0x1874D4FA0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x74D4F50", Offset = "0x74D3550", VA = "0x1874D4F50")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x74D4F00", Offset = "0x74D3500", VA = "0x1874D4F00")]
		private void HEAHLLHCJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x74D55B0", Offset = "0x74D3BB0", VA = "0x1874D55B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74D5500", Offset = "0x74D3B00", VA = "0x1874D5500", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x74D5500", Offset = "0x74D3B00", VA = "0x1874D5500", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class NCFEDCJFIEI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NCFCEOBAOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x965BF0", Offset = "0x9641F0", VA = "0x180965BF0")]
		[DebuggerHidden]
		public NCFEDCJFIEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74DC130", Offset = "0x74DA730", VA = "0x1874DC130", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x74DBCC0", Offset = "0x74DA2C0", VA = "0x1874DBCC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x74DBC70", Offset = "0x74DA270", VA = "0x1874DBC70")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74DBC20", Offset = "0x74DA220", VA = "0x1874DBC20")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x74DC0E0", Offset = "0x74DA6E0", VA = "0x1874DC0E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x74DC030", Offset = "0x74DA630", VA = "0x1874DC030", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74DC030", Offset = "0x74DA630", VA = "0x1874DC030", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OKDJKDPEEAA NCIIFBLDHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<KCIFMIMPOKI> AMOIFDHOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> AIFDCLFDGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer IGHOGDFOOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool CLEALPKIFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool ADBIMLBNNEM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<AGHAKNFLOIH> KHPOCHJKPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DIPEDKJGOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74DAD40", Offset = "0x74D9340", VA = "0x1874DAD40", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OLHIMCMANHM PMDGPPHHPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74DAC70", Offset = "0x74D9270", VA = "0x1874DAC70", Slot = "8")]
		get
		{
			return default(OLHIMCMANHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> GOGCLDKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8860B0", VA = "0x180887AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74DB0C0", Offset = "0x74D96C0", VA = "0x1874DB0C0")]
	private bool JJINCKBGDFD(KCIFMIMPOKI CICGHDIEJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74DB0A0", Offset = "0x74D96A0", VA = "0x1874DB0A0")]
	private static bool HKICPDIBELD(KCIFMIMPOKI CICGHDIEJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74DBB30", Offset = "0x74DA130", VA = "0x1874DBB30")]
	public NCFCEOBAOLK(OKDJKDPEEAA JGCMECODHDI, bool IHMHDCHOBBE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74DAD80", Offset = "0x74D9380", VA = "0x1874DAD80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74DAF00", Offset = "0x74D9500", VA = "0x1874DAF00")]
	public void FABNFHGMHGJ(KCIFMIMPOKI CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74DB3B0", Offset = "0x74D99B0", VA = "0x1874DB3B0")]
	public void MBEEDABKNGP(KCIFMIMPOKI CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x74DA330", Offset = "0x74D8930", VA = "0x1874DA330", Slot = "4")]
	public void ACLMOFJBHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x74DB0E0", Offset = "0x74D96E0", VA = "0x1874DB0E0")]
	public void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74DA980", Offset = "0x74D8F80", VA = "0x1874DA980")]
	private void BBGJCAGOANP(List<KCIFMIMPOKI> AMOIFDHOHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x74DA000", Offset = "0x74D8600", VA = "0x1874DA000")]
	private static Material JCFJPCDJPFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74DAB40", Offset = "0x74D9140", VA = "0x1874DAB40")]
	private void BBGJCAGOANP(KCIFMIMPOKI CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x74DA830", Offset = "0x74D8E30", VA = "0x1874DA830")]
	private void AFFJIELFJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74DB4D0", Offset = "0x74D9AD0", VA = "0x1874DB4D0")]
	public void PEHOAPNMMFD(bool LLOMPKPPNOD, bool HANDODOOGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x74DBA70", Offset = "0x74DA070", VA = "0x1874DBA70")]
	protected void PLMOAEDEBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74DA900", Offset = "0x74D8F00", VA = "0x1874DA900")]
	public void AMCJLLEIMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74DABF0", Offset = "0x74D91F0", VA = "0x1874DABF0")]
	[IteratorStateMachine(typeof(JHFCFHHHPKN))]
	public IEnumerable<Renderer> BEDLOOCBPJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74DB330", Offset = "0x74D9930", VA = "0x1874DB330")]
	[IteratorStateMachine(typeof(NCFEDCJFIEI))]
	public IEnumerable<Renderer> LDKMBAECKIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class JBBBDCNLBCH : KCIFMIMPOKI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct EMEDBILBMPP : CHKKEPPLFAL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private JOIDBGKONGK CBNKKMIFMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle GDNIAPJJBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private GIOMCMJJKIO GNKLOBOOKMM;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74CFEA0", Offset = "0x74CE4A0", VA = "0x1874CFEA0")]
		public EMEDBILBMPP(JOIDBGKONGK CBNKKMIFMKD, JobHandle GDNIAPJJBPI, GIOMCMJJKIO GNKLOBOOKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74CFE70", Offset = "0x74CE470", VA = "0x1874CFE70", Slot = "4")]
		public JOIDBGKONGK IKFNBHIKIAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74CFE20", Offset = "0x74CE420", VA = "0x1874CFE20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly CNNALMNKJOG IOKHNNAFAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float MIBHJOKJAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 OHCCIKLBPGK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 CPMPPIAFANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x74D4550", Offset = "0x74D2B50", VA = "0x1874D4550", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x74D4E50", Offset = "0x74D3450", VA = "0x1874D4E50")]
	public JBBBDCNLBCH(NCFCEOBAOLK JPBBEMPIGCM, CNNALMNKJOG JGCMECODHDI, bool IHMHDCHOBBE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "17")]
	public override bool GEAODBDGHOF(OLHIMCMANHM JPBBEMPIGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74D4380", Offset = "0x74D2980", VA = "0x1874D4380", Slot = "18")]
	public override int GAFHMPPANPN(FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x74D3C70", Offset = "0x74D2270", VA = "0x1874D3C70", Slot = "19")]
	public override int EAAFKICFKMB(FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x74D3E40", Offset = "0x74D2440", VA = "0x1874D3E40", Slot = "20")]
	public override Bounds FGDPBAGOBNJ()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xA1F3C0", Offset = "0xA1D9C0", VA = "0x180A1F3C0", Slot = "21")]
	public override float CJEHNCNPENI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x74D3410", Offset = "0x74D1A10", VA = "0x1874D3410", Slot = "22")]
	public override void AEFKNEGFGJM(FDCBHIELGDB CLOHFODGPFM, HKJIDIEMGKL MLDLLLNAJIB, int CPMPGJMHJLF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x74D3BA0", Offset = "0x74D21A0", VA = "0x1874D3BA0", Slot = "23")]
	public override OLHIMCMANHM DMHODGHFLAG()
	{
		return default(OLHIMCMANHM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x74D39F0", Offset = "0x74D1FF0", VA = "0x1874D39F0", Slot = "25")]
	public override NBCIBJODIAO ALDHKLJKAHI()
	{
		return default(NBCIBJODIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x74D4680", Offset = "0x74D2C80", VA = "0x1874D4680", Slot = "26")]
	public override CHKKEPPLFAL POIICKDDDBL(FDCBHIELGDB CLOHFODGPFM, JobHandle GDNIAPJJBPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface DEIMFIKMCNB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NCFCEOBAOLK BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KCIFMIMPOKI BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LFLCJPNELKB BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class OKDMFNOHHLD : JHKJKNJJHAA, IDisposable, DEIMFIKMCNB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CHBINCAOBDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public OKDMFNOHHLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x74CF8C0", Offset = "0x74CDEC0", VA = "0x1874CF8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x74CFDC0", Offset = "0x74CE3C0", VA = "0x1874CFDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GPDANAILPAE<CEFBENDABAG, NCFCEOBAOLK> ODMEMABOOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly GPDANAILPAE<PFBKIGNHCNM, KCIFMIMPOKI> AMOIFDHOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly GPDANAILPAE<OLOMCLKAJLN, LFLCJPNELKB> FKGAOKOEEBE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NCFCEOBAOLK BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74DE900", Offset = "0x74DCF00", VA = "0x1874DE900", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public KCIFMIMPOKI BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x74DE960", Offset = "0x74DCF60", VA = "0x1874DE960", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LFLCJPNELKB BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x74DE8A0", Offset = "0x74DCEA0", VA = "0x1874DE8A0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LJAEFBAEMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x901400", Offset = "0x8FFA00", VA = "0x180901400", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCE9A00", Offset = "0xCE8000", VA = "0x180CE9A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x74E06E0", Offset = "0x74DECE0", VA = "0x1874E06E0")]
	public OKDMFNOHHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x74DE9C0", Offset = "0x74DCFC0", VA = "0x1874DE9C0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x74DF600", Offset = "0x74DDC00", VA = "0x1874DF600", Slot = "4")]
	public CEFBENDABAG KNMKBFJAJKH(OKDJKDPEEAA JGCMECODHDI)
	{
		return default(CEFBENDABAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x74DF390", Offset = "0x74DD990", VA = "0x1874DF390", Slot = "5")]
	public CEFBENDABAG KNMKBFJAJKH(OKDJKDPEEAA JGCMECODHDI, bool IHMHDCHOBBE)
	{
		return default(CEFBENDABAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x74DF140", Offset = "0x74DD740", VA = "0x1874DF140", Slot = "6")]
	public void JOLBMFGOJBP(CEFBENDABAG JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x74DEE00", Offset = "0x74DD400", VA = "0x1874DEE00", Slot = "7")]
	public void FLODNCANFJC(CEFBENDABAG JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74DFBC0", Offset = "0x74DE1C0", VA = "0x1874DFBC0", Slot = "8")]
	public PFBKIGNHCNM NLDGECDOCNG(CEFBENDABAG JPBBEMPIGCM, AHOEJDMJOPP JGCMECODHDI)
	{
		return default(PFBKIGNHCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74DF610", Offset = "0x74DDC10", VA = "0x1874DF610", Slot = "9")]
	public PFBKIGNHCNM MDGNMILNPAJ(CEFBENDABAG JPBBEMPIGCM, CNNALMNKJOG JGCMECODHDI)
	{
		return default(PFBKIGNHCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74E0340", Offset = "0x74DE940", VA = "0x1874E0340", Slot = "11")]
	public void ONPAEGBAAEO(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74E0080", Offset = "0x74DE680", VA = "0x1874E0080", Slot = "10")]
	public void OAJPFGLFGLA(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x74DED90", Offset = "0x74DD390", VA = "0x1874DED90", Slot = "20")]
	public IEnumerable<Renderer> EMEKHHAELFC(CEFBENDABAG JPBBEMPIGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x74DE6A0", Offset = "0x74DCCA0", VA = "0x1874DE6A0", Slot = "12")]
	public OLOMCLKAJLN AODPAKMGMKI(FPCIEBLEOIF JGCMECODHDI)
	{
		return default(OLOMCLKAJLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74E02D0", Offset = "0x74DE8D0", VA = "0x1874E02D0", Slot = "14")]
	public void OCJPAOHBBAG(OLOMCLKAJLN FGDDBCKAJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x74DEC10", Offset = "0x74DD210", VA = "0x1874DEC10", Slot = "16")]
	public Task EKMBMMBEKFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74DE720", Offset = "0x74DCD20", VA = "0x1874DE720", Slot = "17")]
	public Task BMJMGCBHIFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x74DEB40", Offset = "0x74DD140", VA = "0x1874DEB40", Slot = "18")]
	[AsyncStateMachine(typeof(CHBINCAOBDK))]
	public Task ECGGHPDMJDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74DFB30", Offset = "0x74DE130", VA = "0x1874DFB30", Slot = "19")]
	public void NILOHBICFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74DFAD0", Offset = "0x74DE0D0", VA = "0x1874DFAD0", Slot = "13")]
	public void NIGEHPCNNOH(OLOMCLKAJLN FGDDBCKAJKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class OBINFJDPFKO : KCIFMIMPOKI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct PDEKKOFDMCA : CHKKEPPLFAL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private JOIDBGKONGK CBNKKMIFMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle GDNIAPJJBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private DFJCJLEBMPC GNKLOBOOKMM;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x74E0BE0", Offset = "0x74DF1E0", VA = "0x1874E0BE0")]
		public PDEKKOFDMCA(JOIDBGKONGK CBNKKMIFMKD, JobHandle GDNIAPJJBPI, DFJCJLEBMPC GNKLOBOOKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74E0BB0", Offset = "0x74DF1B0", VA = "0x1874E0BB0", Slot = "4")]
		public JOIDBGKONGK IKFNBHIKIAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x74E0B60", Offset = "0x74DF160", VA = "0x1874E0B60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly AHOEJDMJOPP MJHCHFCOEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] NNDJKIHHPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 OHCCIKLBPGK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 GPINHAOOOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x74DDC60", Offset = "0x74DC260", VA = "0x1874DDC60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 CPMPPIAFANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x74DDB30", Offset = "0x74DC130", VA = "0x1874DDB30", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x74DE5F0", Offset = "0x74DCBF0", VA = "0x1874DE5F0")]
	public OBINFJDPFKO(NCFCEOBAOLK JPBBEMPIGCM, AHOEJDMJOPP JGCMECODHDI, bool OBOCHAKALNO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74DD210", Offset = "0x74DB810", VA = "0x1874DD210", Slot = "17")]
	public override bool GEAODBDGHOF(OLHIMCMANHM JPBBEMPIGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x74DD930", Offset = "0x74DBF30", VA = "0x1874DD930")]
	private KINAFICGJBF ICDEAPOJDJO([In] UniformTRS CLHALGFKHOF, [In] float3 FAKNGOLOPND)
	{
		return default(KINAFICGJBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x74DD170", Offset = "0x74DB770", VA = "0x1874DD170", Slot = "18")]
	public override int GAFHMPPANPN(FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x74DCDE0", Offset = "0x74DB3E0", VA = "0x1874DCDE0", Slot = "19")]
	public override int EAAFKICFKMB(FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x74DD0F0", Offset = "0x74DB6F0", VA = "0x1874DD0F0", Slot = "20")]
	public override Bounds FGDPBAGOBNJ()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x74DCC20", Offset = "0x74DB220", VA = "0x1874DCC20", Slot = "21")]
	public override float CJEHNCNPENI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x74DCE80", Offset = "0x74DB480", VA = "0x1874DCE80")]
	private int EIADNCIDPKF(FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x74DC260", Offset = "0x74DA860", VA = "0x1874DC260", Slot = "22")]
	public override void AEFKNEGFGJM(FDCBHIELGDB CLOHFODGPFM, HKJIDIEMGKL MLDLLLNAJIB, int CPMPGJMHJLF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x74DCD10", Offset = "0x74DB310", VA = "0x1874DCD10", Slot = "23")]
	public override OLHIMCMANHM DMHODGHFLAG()
	{
		return default(OLHIMCMANHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA70", Offset = "0x74DB070", VA = "0x1874DCA70", Slot = "25")]
	public override NBCIBJODIAO ALDHKLJKAHI()
	{
		return default(NBCIBJODIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x74DDE90", Offset = "0x74DC490", VA = "0x1874DDE90", Slot = "26")]
	public override CHKKEPPLFAL POIICKDDDBL(FDCBHIELGDB CLOHFODGPFM, JobHandle GDNIAPJJBPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AGICLDGIFGL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOIHEOMCDCO(IMLALIAHABD JLAAKHANEHC, Renderer MGJKLBPNDCE, int MGDHGJGDDPB);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPDLGHDBELJ(Renderer MGJKLBPNDCE, JDEOPKDIACG BAINLMIMOJN, Vector3 LAMFKJDOOGB, Vector3 JJLHPABKFIF, Vector3 HMJIBDEFLEB, float MPBLCNAKEPE, float NHIPNFOIHAM, float CIGHHAIPKID = -1f, [Optional] Color? FEHNKBJAMFH, [Optional] IReadOnlyList<Camera> IMCAJECNAEF);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNGJCNDPLBH(Renderer MGJKLBPNDCE, int MGDHGJGDDPB);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OGAANAONBDB();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJEBBDEEFNJ(int JENAOFLJOKP, CEKFCLEOOAA JLAAKHANEHC, Renderer MGJKLBPNDCE, int MGDHGJGDDPB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HHFHLHMOKGG : CGKOFOPGADE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class LFJBNAABODP : GGGNMKNBIOM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74D6800", Offset = "0x74D4E00", VA = "0x1874D6800")]
		public LFJBNAABODP(string KJPHMNNIMDP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AGICLDGIFGL FPMCENHPHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DEIMFIKMCNB MOHEHAEHJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer MMLGJNAKNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private LFJBNAABODP PLJENKBIGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool LOGFGHHAFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer CDJBBCDDCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private LFJBNAABODP FOINCKKLECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool FHOHJBCKPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer JIJLLJEBCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private LFJBNAABODP AGGOILEKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool CNODAACHNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool HFIMBOHAJFI;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x88AB80", Offset = "0x889180", VA = "0x18088AB80")]
	public HHFHLHMOKGG(AGICLDGIFGL PEOCJAHEBJI, DEIMFIKMCNB MOHEHAEHJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x74D06A0", Offset = "0x74CECA0", VA = "0x1874D06A0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x74D18B0", Offset = "0x74CFEB0", VA = "0x1874D18B0")]
	private void IOIHECFHDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x74D0390", Offset = "0x74CE990", VA = "0x1874D0390", Slot = "4")]
	public void BNCMMGIEJPP(CEFBENDABAG JPBBEMPIGCM, CEKFCLEOOAA IFNKPCOLBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x74D0170", Offset = "0x74CE770", VA = "0x1874D0170", Slot = "5")]
	public void BNCMMGIEJPP(PFBKIGNHCNM CICGHDIEJHI, CEKFCLEOOAA IFNKPCOLBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x74D0980", Offset = "0x74CEF80", VA = "0x1874D0980", Slot = "6")]
	public void EHLCBEDLPBH(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74D0D20", Offset = "0x74CF320", VA = "0x1874D0D20", Slot = "7")]
	public void FOBOKDIHOFP(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x74D0EC0", Offset = "0x74CF4C0", VA = "0x1874D0EC0", Slot = "24")]
	public void HHKBPEGGMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA14110", Offset = "0xA12710", VA = "0x180A14110", Slot = "8")]
	public void PFGLHENPNAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x74D1B20", Offset = "0x74D0120", VA = "0x1874D1B20", Slot = "9")]
	public void JGHHGFFPHCM(CEKFCLEOOAA IFNKPCOLBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x74D0F00", Offset = "0x74CF500", VA = "0x1874D0F00", Slot = "10")]
	public void ICCOFFKHLNE(CEFBENDABAG JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x74D11E0", Offset = "0x74CF7E0", VA = "0x1874D11E0", Slot = "11")]
	public void ICCOFFKHLNE(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x74D26C0", Offset = "0x74D0CC0", VA = "0x1874D26C0", Slot = "12")]
	public void OLMENNELCKA(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x74D1820", Offset = "0x74CFE20", VA = "0x1874D1820", Slot = "13")]
	public void INHHKJGDFBF(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x74CFF00", Offset = "0x74CE500", VA = "0x1874CFF00")]
	private void BEMOKDOENNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xB117D0", Offset = "0xB0FDD0", VA = "0x180B117D0", Slot = "14")]
	public void PCHGFNMLAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x74D1C90", Offset = "0x74D0290", VA = "0x1874D1C90", Slot = "15")]
	public void KBKBDMECOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x74D1540", Offset = "0x74CFB40", VA = "0x1874D1540", Slot = "16")]
	public void IMBBLJNPHHA(CEFBENDABAG JPBBEMPIGCM, IMLALIAHABD JLAAKHANEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x74D2620", Offset = "0x74D0C20", VA = "0x1874D2620", Slot = "17")]
	public void MJMFHNEJNNC(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x74D0E30", Offset = "0x74CF430", VA = "0x1874D0E30", Slot = "18")]
	public void GIBEPMAGHPI(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xC1B8C0", Offset = "0xC19EC0", VA = "0x180C1B8C0", Slot = "19")]
	public void KBBEIOCICIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x74D0850", Offset = "0x74CEE50", VA = "0x1874D0850", Slot = "20")]
	public void EBNKJFIELNB(IMLALIAHABD JLAAKHANEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x74D0AB0", Offset = "0x74CF0B0", VA = "0x1874D0AB0")]
	private void FNMLCECLIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x74D2250", Offset = "0x74D0850", VA = "0x1874D2250", Slot = "21")]
	public void KGAMJEOAINN(CEFBENDABAG JPBBEMPIGCM, Vector3 LAMFKJDOOGB, Vector3 JJLHPABKFIF, Vector3 HMJIBDEFLEB, float MPBLCNAKEPE, float NHIPNFOIHAM, IReadOnlyList<Camera> GOMIOHNDHBK, JDEOPKDIACG BAINLMIMOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x74D1DB0", Offset = "0x74D03B0", VA = "0x1874D1DB0", Slot = "22")]
	public void KGAMJEOAINN(OLOMCLKAJLN FGDDBCKAJKG, Vector3 LAMFKJDOOGB, Vector3 JJLHPABKFIF, Vector3 HMJIBDEFLEB, float MPBLCNAKEPE, float NHIPNFOIHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KCIFMIMPOKI : EKCACEEIPAG, AGHAKNFLOIH, EKENLHCAPBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly NCFCEOBAOLK GEBPHFIJDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds ENPJLKHMPCK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds JFPFHENAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x120D670", Offset = "0x120BC70", VA = "0x18120D670", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool ADBIMLBNNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB77770", Offset = "0xB75D70", VA = "0x180B77770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC6AF80", Offset = "0xC69580", VA = "0x180C6AF80")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 CPMPPIAFANH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CIBGOOGHOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3E0", Offset = "0x8F99E0", VA = "0x1808FB3E0", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BKCLCHMHELJ OIBAJOENEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8860B0", VA = "0x180887AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool CJKPDLGJGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x166E670", Offset = "0x166CC70", VA = "0x18166E670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	protected KCIFMIMPOKI(NCFCEOBAOLK JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x74D66A0", Offset = "0x74D4CA0", VA = "0x1874D66A0", Slot = "16")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "17")]
	public virtual bool GEAODBDGHOF(OLHIMCMANHM JPBBEMPIGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int GAFHMPPANPN(FDCBHIELGDB CLOHFODGPFM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int EAAFKICFKMB(FDCBHIELGDB CLOHFODGPFM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract Bounds FGDPBAGOBNJ();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract float CJEHNCNPENI();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract void AEFKNEGFGJM(FDCBHIELGDB CLOHFODGPFM, HKJIDIEMGKL MLDLLLNAJIB, int CPMPGJMHJLF = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract OLHIMCMANHM DMHODGHFLAG();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x74D67D0", Offset = "0x74D4DD0", VA = "0x1874D67D0", Slot = "12")]
	public Hash128 IEIANCELHGK(int CLOHFODGPFM)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract NBCIBJODIAO ALDHKLJKAHI();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract CHKKEPPLFAL POIICKDDDBL(FDCBHIELGDB CLOHFODGPFM, JobHandle GDNIAPJJBPI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x74D6670", Offset = "0x74D4C70", VA = "0x1874D6670", Slot = "11")]
	public CHKKEPPLFAL CCHDKKMCFLL(int CLOHFODGPFM)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x74E1030", Offset = "0x74DF630", VA = "0x1874E1030")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LOKCJOCIDHC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class ILBIPBHMJAB : IEnumerable<GDJEGFEFPKO>, IEnumerable, IEnumerator<GDJEGFEFPKO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private GDJEGFEFPKO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private GDJEGFEFPKO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x965BF0", Offset = "0x9641F0", VA = "0x180965BF0")]
		[DebuggerHidden]
		public ILBIPBHMJAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x74D3050", Offset = "0x74D1650", VA = "0x1874D3050", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x74D31C0", Offset = "0x74D17C0", VA = "0x1874D31C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x74D3120", Offset = "0x74D1720", VA = "0x1874D3120", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GDJEGFEFPKO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x74D3120", Offset = "0x74D1720", VA = "0x1874D3120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static GDJEGFEFPKO[][] KJNBEFBEAGI;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static MANEHJEPDED DBDBDCPEMND;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig MJPOMPGCBME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x74D89D0", Offset = "0x74D6FD0", VA = "0x1874D89D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader EKCOBHCFBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x74D8960", Offset = "0x74D6F60", VA = "0x1874D8960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer PIPKODFHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x74D88F0", Offset = "0x74D6EF0", VA = "0x1874D88F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x74D8A10", Offset = "0x74D7010", VA = "0x1874D8A10")]
	public static Mesh NLMLJKHCKCB(DIKIEBBPIBF JBDINOJGNAI, int CLOHFODGPFM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74D7E80", Offset = "0x74D6480", VA = "0x1874D7E80")]
	public static int ALGFCBEOLBG(DIKIEBBPIBF JBDINOJGNAI, int CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x74D8040", Offset = "0x74D6640", VA = "0x1874D8040")]
	public static MANEHJEPDED CDPDPIIFMPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x74D8180", Offset = "0x74D6780", VA = "0x1874D8180")]
	[IteratorStateMachine(typeof(ILBIPBHMJAB))]
	private static IEnumerable<GDJEGFEFPKO> CLOHMLELKGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x74D81E0", Offset = "0x74D67E0", VA = "0x1874D81E0")]
	public static GDJEGFEFPKO FHNFEEIOCAB(DIKIEBBPIBF JBDINOJGNAI, int CLOHFODGPFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x74D88D0", Offset = "0x74D6ED0", VA = "0x1874D88D0")]
	public static bool HENKGHPLAKM(this DIKIEBBPIBF JBDINOJGNAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x74D7E90", Offset = "0x74D6490", VA = "0x1874D7E90")]
	public static void CDAGPGGAALK(DIKIEBBPIBF JBDINOJGNAI, float3 FHCDJLJMHAF, [Out] DFECJDBCKPF FKBEGEAOLBI, [Out] float3 LLLCGLMBOML, [Out] float GNIPIOKOKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x74D8480", Offset = "0x74D6A80", VA = "0x1874D8480")]
	public static void HELLIFAOOFF(Vector3 FHCDJLJMHAF, DIKIEBBPIBF JBDINOJGNAI, [Out] Vector3 LLLCGLMBOML, [Out] float GNIPIOKOKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x74D8A00", Offset = "0x74D7000", VA = "0x1874D8A00")]
	[MGLPINNJGGC(CLPKIHJHCPA.ExitingPlayMode, 0)]
	[CKNHDJDNBDB(0)]
	private static void LGOHIOFDPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x74D7CC0", Offset = "0x74D62C0", VA = "0x1874D7CC0")]
	[MGLPINNJGGC(CLPKIHJHCPA.ExitingPlayMode, 0)]
	[CKNHDJDNBDB(0)]
	private static void ABLFLMCGDMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class JKLHCKHHKHE : JHKJKNJJHAA, IDisposable, DEIMFIKMCNB
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly GPDANAILPAE<CEFBENDABAG, NCFCEOBAOLK> ODMEMABOOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly GPDANAILPAE<PFBKIGNHCNM, KCIFMIMPOKI> AMOIFDHOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly GPDANAILPAE<OLOMCLKAJLN, LFLCJPNELKB> FKGAOKOEEBE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public NCFCEOBAOLK BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x74D5910", Offset = "0x74D3F10", VA = "0x1874D5910", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public KCIFMIMPOKI BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x74D59D0", Offset = "0x74D3FD0", VA = "0x1874D59D0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public LFLCJPNELKB BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x74D5970", Offset = "0x74D3F70", VA = "0x1874D5970", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LJAEFBAEMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x901400", Offset = "0x8FFA00", VA = "0x180901400", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xCE9A00", Offset = "0xCE8000", VA = "0x180CE9A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x74D62B0", Offset = "0x74D48B0", VA = "0x1874D62B0")]
	public JKLHCKHHKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x74D5A30", Offset = "0x74D4030", VA = "0x1874D5A30", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x74D5D50", Offset = "0x74D4350", VA = "0x1874D5D50", Slot = "4")]
	public CEFBENDABAG KNMKBFJAJKH(OKDJKDPEEAA JGCMECODHDI)
	{
		return default(CEFBENDABAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x74D5D50", Offset = "0x74D4350", VA = "0x1874D5D50", Slot = "5")]
	public CEFBENDABAG KNMKBFJAJKH(OKDJKDPEEAA JGCMECODHDI, bool IHMHDCHOBBE)
	{
		return default(CEFBENDABAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x74D5CF0", Offset = "0x74D42F0", VA = "0x1874D5CF0", Slot = "6")]
	public void JOLBMFGOJBP(CEFBENDABAG JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x74D5C70", Offset = "0x74D4270", VA = "0x1874D5C70", Slot = "7")]
	public void FLODNCANFJC(CEFBENDABAG JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x74D5F90", Offset = "0x74D4590", VA = "0x1874D5F90", Slot = "8")]
	public PFBKIGNHCNM NLDGECDOCNG(CEFBENDABAG JPBBEMPIGCM, AHOEJDMJOPP JGCMECODHDI)
	{
		return default(PFBKIGNHCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x74D5DF0", Offset = "0x74D43F0", VA = "0x1874D5DF0", Slot = "9")]
	public PFBKIGNHCNM MDGNMILNPAJ(CEFBENDABAG JPBBEMPIGCM, CNNALMNKJOG JGCMECODHDI)
	{
		return default(PFBKIGNHCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x74D61A0", Offset = "0x74D47A0", VA = "0x1874D61A0", Slot = "11")]
	public void ONPAEGBAAEO(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x74D60D0", Offset = "0x74D46D0", VA = "0x1874D60D0", Slot = "10")]
	public void OAJPFGLFGLA(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x74D5C00", Offset = "0x74D4200", VA = "0x1874D5C00", Slot = "20")]
	public IEnumerable<Renderer> EMEKHHAELFC(CEFBENDABAG JPBBEMPIGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x74D57F0", Offset = "0x74D3DF0", VA = "0x1874D57F0", Slot = "12")]
	public OLOMCLKAJLN AODPAKMGMKI(FPCIEBLEOIF JGCMECODHDI)
	{
		return default(OLOMCLKAJLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x74D6130", Offset = "0x74D4730", VA = "0x1874D6130", Slot = "14")]
	public void OCJPAOHBBAG(OLOMCLKAJLN FGDDBCKAJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x74D5B60", Offset = "0x74D4160", VA = "0x1874D5B60", Slot = "16")]
	public Task EKMBMMBEKFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x74D5870", Offset = "0x74D3E70", VA = "0x1874D5870", Slot = "17")]
	public Task BMJMGCBHIFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x74D5AC0", Offset = "0x74D40C0", VA = "0x1874D5AC0", Slot = "18")]
	public Task ECGGHPDMJDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1FBBBE0", Offset = "0x1FBA1E0", VA = "0x181FBBBE0", Slot = "19")]
	public void NILOHBICFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x74D5F30", Offset = "0x74D4530", VA = "0x1874D5F30", Slot = "13")]
	public void NIGEHPCNNOH(OLOMCLKAJLN FGDDBCKAJKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CENFPDPFCFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool JNFBHKLLCPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KMLJPFGPDGI();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material JCFJPCDJPFG();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material EIKAHOBLEPJ();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NBIHANIOOGK(MNJGJKEDHBM KDLMAHAJHMP);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OEAMMGLNCPN(KLGCHNJKBIE OAHGDGHMOMH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CMIBGCKBBIO(GameObject GHMNBJIOGAM);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMMEDBFNMII(GameObject GHMNBJIOGAM, bool KJBHOGLEKEA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class MEBFDGNGPGI
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static CENFPDPFCFJ BDPEMHOFOHC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool JNFBHKLLCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x74DA060", Offset = "0x74D8660", VA = "0x1874DA060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x74DA190", Offset = "0x74D8790", VA = "0x1874DA190")]
	public static void NKLPCGDJAHO(CENFPDPFCFJ GDFHINAOLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x74DA0C0", Offset = "0x74D86C0", VA = "0x1874DA0C0")]
	public static Material KMLJPFGPDGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x74DA000", Offset = "0x74D8600", VA = "0x1874DA000")]
	public static Material JCFJPCDJPFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x74D9FA0", Offset = "0x74D85A0", VA = "0x1874D9FA0")]
	public static Material EIKAHOBLEPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x74DA120", Offset = "0x74D8720", VA = "0x1874DA120")]
	public static int NBIHANIOOGK(MNJGJKEDHBM KDLMAHAJHMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x74DA1E0", Offset = "0x74D87E0", VA = "0x1874DA1E0")]
	public static int OEAMMGLNCPN(KLGCHNJKBIE OAHGDGHMOMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x74D9EC0", Offset = "0x74D84C0", VA = "0x1874D9EC0")]
	public static void CMIBGCKBBIO(GameObject GHMNBJIOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x74DA250", Offset = "0x74D8850", VA = "0x1874DA250")]
	public static void OMMEDBFNMII(GameObject GHMNBJIOGAM, bool KJBHOGLEKEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LFLCJPNELKB : COHIMFBCGOO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PHCBGJGNJDC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public LFLCJPNELKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x965BF0", Offset = "0x9641F0", VA = "0x180965BF0")]
		[DebuggerHidden]
		public PHCBGJGNJDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x74E0FA0", Offset = "0x74DF5A0", VA = "0x1874E0FA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x74E0C80", Offset = "0x74DF280", VA = "0x1874E0C80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x74E0C30", Offset = "0x74DF230", VA = "0x1874E0C30")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x74E0F50", Offset = "0x74DF550", VA = "0x1874E0F50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x74E0EA0", Offset = "0x74DF4A0", VA = "0x1874E0EA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x74E0EA0", Offset = "0x74DF4A0", VA = "0x1874E0EA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly FPCIEBLEOIF OGAGJEGPNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly DEIMFIKMCNB MOHEHAEHJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private HJJBNOPDMKA LBAOMDABJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<LPKFEFGMLPK> MBPDCIFELMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<LPKFEFGMLPK> BFPPJPGLOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject LOHDGLIKHDP;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x74D6850", Offset = "0x74D4E50", VA = "0x1874D6850")]
	public static LFLCJPNELKB ABMJGBLHAPK(FPCIEBLEOIF JGCMECODHDI, DEIMFIKMCNB MOHEHAEHJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x74D7BE0", Offset = "0x74D61E0", VA = "0x1874D7BE0")]
	private LFLCJPNELKB(FPCIEBLEOIF JGCMECODHDI, DEIMFIKMCNB MOHEHAEHJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x74D7760", Offset = "0x74D5D60", VA = "0x1874D7760")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x74D7490", Offset = "0x74D5A90", VA = "0x1874D7490")]
	[IteratorStateMachine(typeof(PHCBGJGNJDC))]
	public IEnumerable<Renderer> BEDLOOCBPJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x74D69D0", Offset = "0x74D4FD0", VA = "0x1874D69D0", Slot = "4")]
	public void ACLMOFJBHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x74D69A0", Offset = "0x74D4FA0", VA = "0x1874D69A0")]
	private void ACHEFBDCGBE(Vector3 PNPNJFAEELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x74D7510", Offset = "0x74D5B10", VA = "0x1874D7510")]
	public void KOLHFLEMELG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LPKFEFGMLPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct LFDGNNNBKED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public HKJIDIEMGKL ADKGMNILPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public OLHIMCMANHM EEMFEBMIDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int IDBJIDAGBFC;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IPBCABOBGMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LPKFEFGMLPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FDCBHIELGDB lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<LFDGNNNBKED> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public JOIDBGKONGK combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public IPBCABOBGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x74D33B0", Offset = "0x74D19B0", VA = "0x1874D33B0")]
		internal JobHandle KADFCEPNOJB()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x74D3380", Offset = "0x74D1980", VA = "0x1874D3380")]
		internal void IFEFHMAMNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x74D3210", Offset = "0x74D1810", VA = "0x1874D3210")]
		internal void AEIAPEAHGBN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] EBDHENGLPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private OCGODPNCCPB FMPPJBFEAII;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 HKAPNIMGBOC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh JPMOJDIJBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8920C0", Offset = "0x8906C0", VA = "0x1808920C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x74D8B30", Offset = "0x74D7130", VA = "0x1874D8B30")]
	public void ALMALKEDKML(List<OLHIMCMANHM> OKNKEGNKCAD, Matrix4x4[] DABLNAJEGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x74D9110", Offset = "0x74D7710", VA = "0x1874D9110")]
	public static List<LPKFEFGMLPK> GMDNOGMNFLF(List<NCFCEOBAOLK> AJOFDDMLMFO, FDCBHIELGDB CLOHFODGPFM, Bounds NPJFCGGHGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x74D8D10", Offset = "0x74D7310", VA = "0x1874D8D10")]
	private JobHandle AMLFMKNHNOL(JOIDBGKONGK AFCMBJJBHGD, int NPFPKLGDKMF, int DCLJAMBNIMH, FDCBHIELGDB CLOHFODGPFM, List<LFDGNNNBKED> OLGHJFEEACK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x74D97A0", Offset = "0x74D7DA0", VA = "0x1874D97A0")]
	private void KJGEOIJHEJO(List<LFDGNNNBKED> OLGHJFEEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x74D9A10", Offset = "0x74D8010", VA = "0x1874D9A10")]
	private LPKFEFGMLPK(List<LFDGNNNBKED> OLGHJFEEACK, int NPFPKLGDKMF, int DCLJAMBNIMH, FDCBHIELGDB CLOHFODGPFM, Bounds NPJFCGGHGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x74D9070", Offset = "0x74D7670", VA = "0x1874D9070", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private MaterialPropertyBlock PIJDHFGMLNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private LPKFEFGMLPK CBNKKMIFMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<OLHIMCMANHM> MEDPHPPCKBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture OBOBJIJBOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer KMINDBAAGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader JHKDHBPHLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] BBMHBCINKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int GKNBLKBIHPJ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer DNFKLIBBDKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int EGNCMDPIICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x74E1D90", Offset = "0x74E0390", VA = "0x1874E1D90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x74E1400", Offset = "0x74DFA00", VA = "0x1874E1400")]
		public static List<SkinnedShapeRenderer> Create(GameObject JPBBEMPIGCM, List<LPKFEFGMLPK> CBLAEIHFGND, List<OLHIMCMANHM> MEDPHPPCKBJ, Material KFGOIEOLDHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x74E16B0", Offset = "0x74DFCB0", VA = "0x1874E16B0")]
		public void Init(LPKFEFGMLPK CBNKKMIFMKD, List<OLHIMCMANHM> MEDPHPPCKBJ, Material KFGOIEOLDHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x74E1CF0", Offset = "0x74E02F0", VA = "0x1874E1CF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x74E1C50", Offset = "0x74E0250", VA = "0x1874E1C50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x74E1C10", Offset = "0x74E0210", VA = "0x1874E1C10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x74E1B50", Offset = "0x74E0150", VA = "0x1874E1B50")]
		private void OIGFMFLOAHL(ScriptableRenderContext EIGKPCONJCB, Camera[] EMDKHKKHEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x74E1090", Offset = "0x74DF690", VA = "0x1874E1090")]
		private void ALMALKEDKML(CommandBuffer FMDCOJMFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
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
