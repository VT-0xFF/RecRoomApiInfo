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
	public class LogRegistrationIndex : JOPFPPBONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7521C60", Offset = "0x7520660", VA = "0x187521C60", Slot = "4")]
		public override void HEDMFNKAECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EDMJFALBFAP : KMPAAOEDKEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte MGPBEJABDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] GHJEALBECEL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HNKJCDNPOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x918C60", VA = "0x18091A260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int IDNCOJEOPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B70", Offset = "0x8C2570", VA = "0x1808C3B70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FA0", Offset = "0x8C19A0", VA = "0x1808C2FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float LJFCDAAKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x923030", Offset = "0x921A30", VA = "0x180923030", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB61FB0", Offset = "0xB609B0", VA = "0x180B61FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float BCNOPHDKEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x923020", Offset = "0x921A20", VA = "0x180923020", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xFE72F0", Offset = "0xFE5CF0", VA = "0x180FE72F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> NDEMGLFLMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75159A0", Offset = "0x75143A0", VA = "0x1875159A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> IJNANIDDMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7515B90", Offset = "0x7514590", VA = "0x187515B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject AAHAADHCHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8893D0", Offset = "0x887DD0", VA = "0x1808893D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte CLFOFJJLPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7515B40", Offset = "0x7514540", VA = "0x187515B40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7515D20", Offset = "0x7514720", VA = "0x187515D20")]
	public EDMJFALBFAP(List<GPPGMNNLAKN> ELIJGDKIFGK, List<GPPGMNNLAKN> JMIMHDPIDHA, List<HPFOPEMMFAI> MBIOIAAEAKF, Material MLMFHAHBCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7515780", Offset = "0x7514180", VA = "0x187515780")]
	private int CHNABFMIGAD(List<GPPGMNNLAKN> IGECNCLMMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7515BC0", Offset = "0x75145C0", VA = "0x187515BC0")]
	private void MJDLKDBLAPM(int IHHDAIIJPDE, bool LICPECIHEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x75159F0", Offset = "0x75143F0", VA = "0x1875159F0")]
	public void ICJPHHIJPKG(Vector3 JMACEJCBKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x75158A0", Offset = "0x75142A0", VA = "0x1875158A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7515740", Offset = "0x7514140", VA = "0x187515740")]
	public void ALMLBNEICPG(Transform IBCBMJNOMNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EDOJPJFJKJA : KHIHGMBEOEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class BMAEKJJPDPD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EDOJPJFJKJA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x94CA60", Offset = "0x94B460", VA = "0x18094CA60")]
		[DebuggerHidden]
		public BMAEKJJPDPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7515550", Offset = "0x7513F50", VA = "0x187515550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7514EA0", Offset = "0x75138A0", VA = "0x187514EA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7514E50", Offset = "0x7513850", VA = "0x187514E50")]
		private void GPKDFCKBEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75153B0", Offset = "0x7513DB0", VA = "0x1875153B0")]
		private void OLBNGAJNBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7515400", Offset = "0x7513E00", VA = "0x187515400")]
		private void PGMJPHIJBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7515500", Offset = "0x7513F00", VA = "0x187515500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7515450", Offset = "0x7513E50", VA = "0x187515450", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7515450", Offset = "0x7513E50", VA = "0x187515450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MHNALGMLCGD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EDOJPJFJKJA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x94CA60", Offset = "0x94B460", VA = "0x18094CA60")]
		[DebuggerHidden]
		public MHNALGMLCGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7522200", Offset = "0x7520C00", VA = "0x187522200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7521D40", Offset = "0x7520740", VA = "0x187521D40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7521CF0", Offset = "0x75206F0", VA = "0x187521CF0")]
		private void GPKDFCKBEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x75220B0", Offset = "0x7520AB0", VA = "0x1875220B0")]
		private void OLBNGAJNBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x75221B0", Offset = "0x7520BB0", VA = "0x1875221B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7522100", Offset = "0x7520B00", VA = "0x187522100", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7522100", Offset = "0x7520B00", VA = "0x187522100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly ONKGMCFPKGJ BBMHNPDNFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<MLDHHHFLEPP> GECCPLPADIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> EAIIEJOOMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer HNJJOMMAOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool HIPDDIGHOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool JFHKEBLKGMD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<CIFAILKDFMK> DIPIMPACODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ECCDLDGAJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7517770", Offset = "0x7516170", VA = "0x187517770", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HPFOPEMMFAI AAIAAMEFNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7516ED0", Offset = "0x75158D0", VA = "0x187516ED0", Slot = "8")]
		get
		{
			return default(HPFOPEMMFAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> DCIPDKEKEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x891470", Offset = "0x88FE70", VA = "0x180891470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7517570", Offset = "0x7515F70", VA = "0x187517570")]
	private bool HAFMDHAAPGN(MLDHHHFLEPP OEHDLGBIBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7516380", Offset = "0x7514D80", VA = "0x187516380")]
	private static bool DFMKNIJMKAD(MLDHHHFLEPP OEHDLGBIBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7517830", Offset = "0x7516230", VA = "0x187517830")]
	public EDOJPJFJKJA(ONKGMCFPKGJ OIGMDCDEKEG, bool EKIGDGPFEPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7516BB0", Offset = "0x75155B0", VA = "0x187516BB0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7516D30", Offset = "0x7515730", VA = "0x187516D30")]
	public void EGHPKMGPEOO(MLDHHHFLEPP OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7517650", Offset = "0x7516050", VA = "0x187517650")]
	public void MIOFMOMIMDC(MLDHHHFLEPP OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7516FA0", Offset = "0x75159A0", VA = "0x187516FA0", Slot = "4")]
	public void FNFAALCABCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7516130", Offset = "0x7514B30", VA = "0x187516130")]
	public void DBMELBLEALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75163A0", Offset = "0x7514DA0", VA = "0x1875163A0")]
	private void DFNFOADPEMN(List<MLDHHHFLEPP> GECCPLPADIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7514B20", Offset = "0x7513520", VA = "0x187514B20")]
	private static Material BNIENALMIDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7516560", Offset = "0x7514F60", VA = "0x187516560")]
	private void DFNFOADPEMN(MLDHHHFLEPP OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75174A0", Offset = "0x7515EA0", VA = "0x1875174A0")]
	private void GEIKDNOBBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7516610", Offset = "0x7515010", VA = "0x187516610")]
	public void DPELBCIIJMP(bool OODACNNFJAJ, bool BMJKGJPABHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7517590", Offset = "0x7515F90", VA = "0x187517590")]
	protected void LCILBJKEPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7516030", Offset = "0x7514A30", VA = "0x187516030")]
	public void BHDHHKPFCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75160B0", Offset = "0x7514AB0", VA = "0x1875160B0")]
	[IteratorStateMachine(typeof(BMAEKJJPDPD))]
	public IEnumerable<Renderer> BHHAKLFKFPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75177B0", Offset = "0x75161B0", VA = "0x1875177B0")]
	[IteratorStateMachine(typeof(MHNALGMLCGD))]
	public IEnumerable<Renderer> OIHJPHHKGNG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class HJKHPGODBEL : MLDHHHFLEPP
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct JJCCAEBAICA : GLMHPDONIDE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LCFLAENFPKH ANBKEJJPIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle KPAOAOAPKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NNPFDEEKELK GGECGFLFENI;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x751C990", Offset = "0x751B390", VA = "0x18751C990")]
		public JJCCAEBAICA(LCFLAENFPKH ANBKEJJPIHH, JobHandle KPAOAOAPKHJ, NNPFDEEKELK GGECGFLFENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x751C960", Offset = "0x751B360", VA = "0x18751C960", Slot = "4")]
		public LCFLAENFPKH IEGBLMMEELB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x751C910", Offset = "0x751B310", VA = "0x18751C910", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly AFMNBNBECDC CPLACDEMADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float HLDNLPKEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 MPBDKGKMOCF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 NLCACMIEFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x751B6A0", Offset = "0x751A0A0", VA = "0x18751B6A0", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x751C860", Offset = "0x751B260", VA = "0x18751C860")]
	public HJKHPGODBEL(EDOJPJFJKJA MGPJOGDJPHA, AFMNBNBECDC OIGMDCDEKEG, bool EKIGDGPFEPC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "17")]
	public override bool ODIKFJHLDFH(HPFOPEMMFAI MGPJOGDJPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x751AF00", Offset = "0x7519900", VA = "0x18751AF00", Slot = "18")]
	public override int CHNABFMIGAD(KALLCKNDJCE NDKONLLHKBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x751B7D0", Offset = "0x751A1D0", VA = "0x18751B7D0", Slot = "19")]
	public override int ICKIAAGBCNJ(KALLCKNDJCE NDKONLLHKBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x751B9A0", Offset = "0x751A3A0", VA = "0x18751B9A0", Slot = "20")]
	public override Bounds JMGEMEKJEON()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xA183D0", Offset = "0xA16DD0", VA = "0x180A183D0", Slot = "21")]
	public override float IICPKKPEGDP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x751B0D0", Offset = "0x7519AD0", VA = "0x18751B0D0", Slot = "22")]
	public override void FFAPCMHGNMM(KALLCKNDJCE NDKONLLHKBF, IEBIJPNOIHK OAENGBHPIII, int JKKHHBDKLJB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x751AE30", Offset = "0x7519830", VA = "0x18751AE30", Slot = "23")]
	public override HPFOPEMMFAI CEHDDHJKKEI()
	{
		return default(HPFOPEMMFAI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x751C6B0", Offset = "0x751B0B0", VA = "0x18751C6B0", Slot = "25")]
	public override NCBBGIIEAKO PPBFILLKHAB()
	{
		return default(NCBBGIIEAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x751BEE0", Offset = "0x751A8E0", VA = "0x18751BEE0", Slot = "26")]
	public override GLMHPDONIDE MHMKMAKKMEO(KALLCKNDJCE NDKONLLHKBF, JobHandle KPAOAOAPKHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface ELAKIILNLGH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EDOJPJFJKJA MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MLDHHHFLEPP MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	AHLMEOBHIOD MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class LFHAJJCINGL : ONKLLCFHLEK, IDisposable, ELAKIILNLGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct JJFEACEHOKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LFHAJJCINGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x751C9F0", Offset = "0x751B3F0", VA = "0x18751C9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x751CEF0", Offset = "0x751B8F0", VA = "0x18751CEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HOGHJPHDJNN<DLDFPOMGDOP, EDOJPJFJKJA> IPBKNFPMMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HOGHJPHDJNN<DDLNHDPCINE, MLDHHHFLEPP> GECCPLPADIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HOGHJPHDJNN<KCNFFJOGDNE, AHLMEOBHIOD> KNIDENBFFMB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EDOJPJFJKJA MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x751D910", Offset = "0x751C310", VA = "0x18751D910", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MLDHHHFLEPP MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x751D8B0", Offset = "0x751C2B0", VA = "0x18751D8B0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AHLMEOBHIOD MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x751D970", Offset = "0x751C370", VA = "0x18751D970", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PEEGDHAFIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8FEDF0", Offset = "0x8FD7F0", VA = "0x1808FEDF0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCE8060", Offset = "0xCE6A60", VA = "0x180CE8060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x751EF90", Offset = "0x751D990", VA = "0x18751EF90")]
	public LFHAJJCINGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x751D9D0", Offset = "0x751C3D0", VA = "0x18751D9D0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x751DDC0", Offset = "0x751C7C0", VA = "0x18751DDC0", Slot = "4")]
	public DLDFPOMGDOP EJBNCBJEKIC(ONKGMCFPKGJ OIGMDCDEKEG)
	{
		return default(DLDFPOMGDOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x751DB50", Offset = "0x751C550", VA = "0x18751DB50", Slot = "5")]
	public DLDFPOMGDOP EJBNCBJEKIC(ONKGMCFPKGJ OIGMDCDEKEG, bool EKIGDGPFEPC)
	{
		return default(DLDFPOMGDOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x751DF50", Offset = "0x751C950", VA = "0x18751DF50", Slot = "6")]
	public void EOECMCBAIKJ(DLDFPOMGDOP MGPJOGDJPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x751D0B0", Offset = "0x751BAB0", VA = "0x18751D0B0", Slot = "7")]
	public void BKHLCINMMEI(DLDFPOMGDOP MGPJOGDJPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x751E1A0", Offset = "0x751CBA0", VA = "0x18751E1A0", Slot = "8")]
	public DDLNHDPCINE HOKIINLNBLJ(DLDFPOMGDOP MGPJOGDJPHA, HKOHCMODGAK OIGMDCDEKEG)
	{
		return default(DDLNHDPCINE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x751D3F0", Offset = "0x751BDF0", VA = "0x18751D3F0", Slot = "9")]
	public DDLNHDPCINE DMPLALIKEPJ(DLDFPOMGDOP MGPJOGDJPHA, AFMNBNBECDC OIGMDCDEKEG)
	{
		return default(DDLNHDPCINE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x751EBF0", Offset = "0x751D5F0", VA = "0x18751EBF0", Slot = "11")]
	public void PNBCPAFHCGG(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x751E660", Offset = "0x751D060", VA = "0x18751E660", Slot = "10")]
	public void IADOHFMCKKH(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x751E8B0", Offset = "0x751D2B0", VA = "0x18751E8B0", Slot = "20")]
	public IEnumerable<Renderer> ILNFFMMKKPE(DLDFPOMGDOP MGPJOGDJPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x751EB10", Offset = "0x751D510", VA = "0x18751EB10", Slot = "12")]
	public KCNFFJOGDNE JHPEKKEFFMA(CCBKJCBBPEG OIGMDCDEKEG)
	{
		return default(KCNFFJOGDNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x751EAA0", Offset = "0x751D4A0", VA = "0x18751EAA0", Slot = "14")]
	public void JCFHHDLOHHE(KCNFFJOGDNE CKKGBLDOPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x751DDD0", Offset = "0x751C7D0", VA = "0x18751DDD0", Slot = "16")]
	public Task ENDLDHILDHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x751E920", Offset = "0x751D320", VA = "0x18751E920", Slot = "17")]
	public Task ILPPECDGBLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x751CFE0", Offset = "0x751B9E0", VA = "0x18751CFE0", Slot = "18")]
	[AsyncStateMachine(typeof(JJFEACEHOKG))]
	public Task ALMGDFIKPHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x751CF50", Offset = "0x751B950", VA = "0x18751CF50", Slot = "19")]
	public void AICEPEEFDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x751EB90", Offset = "0x751D590", VA = "0x18751EB90", Slot = "13")]
	public void PCJLFKDPNDF(KCNFFJOGDNE CKKGBLDOPHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class OJAPLJHMPHG : MLDHHHFLEPP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct GOCEGEMNOLH : GLMHPDONIDE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private LCFLAENFPKH ANBKEJJPIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle KPAOAOAPKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JNGINCENJIL GGECGFLFENI;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7519AE0", Offset = "0x75184E0", VA = "0x187519AE0")]
		public GOCEGEMNOLH(LCFLAENFPKH ANBKEJJPIHH, JobHandle KPAOAOAPKHJ, JNGINCENJIL GGECGFLFENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7519AB0", Offset = "0x75184B0", VA = "0x187519AB0", Slot = "4")]
		public LCFLAENFPKH IEGBLMMEELB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7519A60", Offset = "0x7518460", VA = "0x187519A60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly HKOHCMODGAK CNPFJDANIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] GLMAKGENPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 MPBDKGKMOCF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 EIMLJKPALIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7522E40", Offset = "0x7521840", VA = "0x187522E40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 NLCACMIEFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7523070", Offset = "0x7521A70", VA = "0x187523070", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7524850", Offset = "0x7523250", VA = "0x187524850")]
	public OJAPLJHMPHG(EDOJPJFJKJA MGPJOGDJPHA, HKOHCMODGAK OIGMDCDEKEG, bool PMJNIILOCLL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7523F80", Offset = "0x7522980", VA = "0x187523F80", Slot = "17")]
	public override bool ODIKFJHLDFH(HPFOPEMMFAI MGPJOGDJPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x75233B0", Offset = "0x7521DB0", VA = "0x1875233B0")]
	private ANGGEMEBBDI KOLOJONJAIJ([In] UniformTRS LJGPGIJNJDM, [In] float3 DOJFKIKPNCC)
	{
		return default(ANGGEMEBBDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7522590", Offset = "0x7520F90", VA = "0x187522590", Slot = "18")]
	public override int CHNABFMIGAD(KALLCKNDJCE NDKONLLHKBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x75231A0", Offset = "0x7521BA0", VA = "0x1875231A0", Slot = "19")]
	public override int ICKIAAGBCNJ(KALLCKNDJCE NDKONLLHKBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7523330", Offset = "0x7521D30", VA = "0x187523330", Slot = "20")]
	public override Bounds JMGEMEKJEON()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7523240", Offset = "0x7521C40", VA = "0x187523240", Slot = "21")]
	public override float IICPKKPEGDP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7523D10", Offset = "0x7522710", VA = "0x187523D10")]
	private int MIEMBEGKNCP(KALLCKNDJCE NDKONLLHKBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7522630", Offset = "0x7521030", VA = "0x187522630", Slot = "22")]
	public override void FFAPCMHGNMM(KALLCKNDJCE NDKONLLHKBF, IEBIJPNOIHK OAENGBHPIII, int JKKHHBDKLJB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x75224C0", Offset = "0x7520EC0", VA = "0x1875224C0", Slot = "23")]
	public override HPFOPEMMFAI CEHDDHJKKEI()
	{
		return default(HPFOPEMMFAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x75246A0", Offset = "0x75230A0", VA = "0x1875246A0", Slot = "25")]
	public override NCBBGIIEAKO PPBFILLKHAB()
	{
		return default(NCBBGIIEAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x75235B0", Offset = "0x7521FB0", VA = "0x1875235B0", Slot = "26")]
	public override GLMHPDONIDE MHMKMAKKMEO(KALLCKNDJCE NDKONLLHKBF, JobHandle KPAOAOAPKHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IGCPMEDONAN
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKIPILABDKG(MKHKMPLGLOM NNCMOPPBEEE, Renderer AAPNFNNCHNO, int JPKAGKPIOPE);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMJMBHOHJJH(Renderer AAPNFNNCHNO, HIKLJPELLBA KPLKEEMGIKF, Vector3 DOAODIEEIGN, Vector3 HNIIDGAFLFD, Vector3 CFCCIEPFNEJ, float HFDFAGCHKHB, float IEGJNCIIPAH, float DFELGNLCMDE = -1f, [Optional] Color? BLBBBKOLGJG, [Optional] IReadOnlyList<Camera> DAOKFPJNCCE);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEBLMHLGDBB(Renderer AAPNFNNCHNO, int JPKAGKPIOPE);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int APGPLGJDCBH();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DGPIONEPIOD(int EFGNIGJOCFM, NIDBICOIDOK NNCMOPPBEEE, Renderer AAPNFNNCHNO, int JPKAGKPIOPE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LJONNGFHOLN : CBHFJOBOEMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class GLGEOHMCONJ : AHLNIOJDLPC<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7519610", Offset = "0x7518010", VA = "0x187519610")]
		public GLGEOHMCONJ(string HBOONHFLONJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IGCPMEDONAN OHLPFLCIMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly ELAKIILNLGH IKKHLJONICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer POLEPOIHNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private GLGEOHMCONJ ONLDMJPOLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool DDIDKMPEHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer JGFPLHCJHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private GLGEOHMCONJ DGEKCHHFAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool BACOOEJODIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer ADBGMGBIDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private GLGEOHMCONJ JJPDHHGEBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool NKFILCMGNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool JJAPMBJBFNG;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x88B090", Offset = "0x889A90", VA = "0x18088B090")]
	public LJONNGFHOLN(IGCPMEDONAN PFALJNCKCKF, ELAKIILNLGH IKKHLJONICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x75205F0", Offset = "0x751EFF0", VA = "0x1875205F0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7521070", Offset = "0x751FA70", VA = "0x187521070")]
	private void NBPDLOFHKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7520010", Offset = "0x751EA10", VA = "0x187520010", Slot = "4")]
	public void APCDMONNIEG(DLDFPOMGDOP MGPJOGDJPHA, NIDBICOIDOK GHFGJIAINPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x751FDF0", Offset = "0x751E7F0", VA = "0x18751FDF0", Slot = "5")]
	public void APCDMONNIEG(DDLNHDPCINE OEHDLGBIBKH, NIDBICOIDOK GHFGJIAINPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7520EB0", Offset = "0x751F8B0", VA = "0x187520EB0", Slot = "6")]
	public void MFGECPMCBKA(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x75204E0", Offset = "0x751EEE0", VA = "0x1875204E0", Slot = "7")]
	public void DKBJPAMDMEH(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x75219B0", Offset = "0x75203B0", VA = "0x1875219B0", Slot = "24")]
	public void OJDMOADNJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA12800", Offset = "0xA11200", VA = "0x180A12800", Slot = "8")]
	public void NPINOOIIEAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x751F410", Offset = "0x751DE10", VA = "0x18751F410", Slot = "9")]
	public void ABIOBAGCCBM(NIDBICOIDOK GHFGJIAINPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7521640", Offset = "0x7520040", VA = "0x187521640", Slot = "10")]
	public void NOLFGMDILJJ(DLDFPOMGDOP MGPJOGDJPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x75212E0", Offset = "0x751FCE0", VA = "0x1875212E0", Slot = "11")]
	public void NOLFGMDILJJ(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7520320", Offset = "0x751ED20", VA = "0x187520320", Slot = "12")]
	public void CAPNFJHFCNK(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7520FE0", Offset = "0x751F9E0", VA = "0x187520FE0", Slot = "13")]
	public void MOMPADJAPCB(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x75207A0", Offset = "0x751F1A0", VA = "0x1875207A0")]
	private void IBLJBDFJNBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xB0D550", Offset = "0xB0BF50", VA = "0x180B0D550", Slot = "14")]
	public void JDCIPJBDIDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x75203C0", Offset = "0x751EDC0", VA = "0x1875203C0", Slot = "15")]
	public void DDBCGDPAIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7520A10", Offset = "0x751F410", VA = "0x187520A10", Slot = "16")]
	public void LEGBJMHCLNB(DLDFPOMGDOP MGPJOGDJPHA, MKHKMPLGLOM NNCMOPPBEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7521910", Offset = "0x7520310", VA = "0x187521910", Slot = "17")]
	public void ODNIHGEGGPA(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7520CF0", Offset = "0x751F6F0", VA = "0x187520CF0", Slot = "18")]
	public void LHPKJFBAJIC(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xC11010", Offset = "0xC0FA10", VA = "0x180C11010", Slot = "19")]
	public void AHBMKMDAMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7520D80", Offset = "0x751F780", VA = "0x187520D80", Slot = "20")]
	public void LMPLGLIBDIO(MKHKMPLGLOM NNCMOPPBEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x75219F0", Offset = "0x75203F0", VA = "0x1875219F0")]
	private void ONHEEAFJGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x751F580", Offset = "0x751DF80", VA = "0x18751F580", Slot = "21")]
	public void AIOGMFDAHOH(DLDFPOMGDOP MGPJOGDJPHA, Vector3 DOAODIEEIGN, Vector3 HNIIDGAFLFD, Vector3 CFCCIEPFNEJ, float HFDFAGCHKHB, float IEGJNCIIPAH, IReadOnlyList<Camera> HKDKAPGAJPO, HIKLJPELLBA KPLKEEMGIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x751F950", Offset = "0x751E350", VA = "0x18751F950", Slot = "22")]
	public void AIOGMFDAHOH(KCNFFJOGDNE CKKGBLDOPHM, Vector3 DOAODIEEIGN, Vector3 HNIIDGAFLFD, Vector3 CFCCIEPFNEJ, float HFDFAGCHKHB, float IEGJNCIIPAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class MLDHHHFLEPP : LFDHENDANBM, CIFAILKDFMK, PCFLDAECEMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly EDOJPJFJKJA AAHAADHCHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds JBGNJIDHJOH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds HMHDFIIPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x12091D0", Offset = "0x1207BD0", VA = "0x1812091D0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool JFHKEBLKGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB75510", Offset = "0xB73F10", VA = "0x180B75510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC622D0", Offset = "0xC60CD0", VA = "0x180C622D0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 NLCACMIEFPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BMIAJKLHKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x900EE0", Offset = "0x8FF8E0", VA = "0x180900EE0", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public FKCFHHKMHBJ IKDGILAKCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x891470", Offset = "0x88FE70", VA = "0x180891470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EDPENBOMMME
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1667C20", Offset = "0x1666620", VA = "0x181667C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	protected MLDHHHFLEPP(EDOJPJFJKJA MGPJOGDJPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7522360", Offset = "0x7520D60", VA = "0x187522360", Slot = "16")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "17")]
	public virtual bool ODIKFJHLDFH(HPFOPEMMFAI MGPJOGDJPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int CHNABFMIGAD(KALLCKNDJCE NDKONLLHKBF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int ICKIAAGBCNJ(KALLCKNDJCE NDKONLLHKBF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract Bounds JMGEMEKJEON();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract float IICPKKPEGDP();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract void FFAPCMHGNMM(KALLCKNDJCE NDKONLLHKBF, IEBIJPNOIHK OAENGBHPIII, int JKKHHBDKLJB = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract HPFOPEMMFAI CEHDDHJKKEI();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7522330", Offset = "0x7520D30", VA = "0x187522330", Slot = "12")]
	public Hash128 CGMEANJKANE(int NDKONLLHKBF)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract NCBBGIIEAKO PPBFILLKHAB();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract GLMHPDONIDE MHMKMAKKMEO(KALLCKNDJCE NDKONLLHKBF, JobHandle KPAOAOAPKHJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7522490", Offset = "0x7520E90", VA = "0x187522490", Slot = "11")]
	public GLMHPDONIDE GOBHLOIHFDL(int NDKONLLHKBF)
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
		[Cpp2IlInjected.Address(RVA = "0x7524900", Offset = "0x7523300", VA = "0x187524900")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GAFENODIOIK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class AHOBFJMKNAN : IEnumerable<MCEFCNOJFEO>, IEnumerable, IEnumerator<MCEFCNOJFEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private MCEFCNOJFEO <>2__current;

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
		private MCEFCNOJFEO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x94CA60", Offset = "0x94B460", VA = "0x18094CA60")]
		[DebuggerHidden]
		public AHOBFJMKNAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7514830", Offset = "0x7513230", VA = "0x187514830", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x75149A0", Offset = "0x75133A0", VA = "0x1875149A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7514900", Offset = "0x7513300", VA = "0x187514900", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MCEFCNOJFEO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7514900", Offset = "0x7513300", VA = "0x187514900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static MCEFCNOJFEO[][] FHKOEHEOPOH;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static MAFJEFDKHKP NNIAHBLMDFF;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig KJPKGEHBOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7519570", Offset = "0x7517F70", VA = "0x187519570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader BDDPEOEIDBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x75194E0", Offset = "0x7517EE0", VA = "0x1875194E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer PHOPGIABBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x75192A0", Offset = "0x7517CA0", VA = "0x1875192A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x75191F0", Offset = "0x7517BF0", VA = "0x1875191F0")]
	public static Mesh LOKOFNEOGNJ(DLBBPBLJBPM MMJGFNALDMG, int NDKONLLHKBF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7518800", Offset = "0x7517200", VA = "0x187518800")]
	public static int CCMHFKIHEEM(DLBBPBLJBPM MMJGFNALDMG, int NDKONLLHKBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7518AB0", Offset = "0x75174B0", VA = "0x187518AB0")]
	public static MAFJEFDKHKP ICJINELEOLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x75187A0", Offset = "0x75171A0", VA = "0x1875187A0")]
	[IteratorStateMachine(typeof(AHOBFJMKNAN))]
	private static IEnumerable<MCEFCNOJFEO> BIMHPMKLJIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7518810", Offset = "0x7517210", VA = "0x187518810")]
	public static MCEFCNOJFEO HMMPAAKOEKL(DLBBPBLJBPM MMJGFNALDMG, int NDKONLLHKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7519550", Offset = "0x7517F50", VA = "0x187519550")]
	public static bool POCDIJOIEKB(this DLBBPBLJBPM MMJGFNALDMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7519040", Offset = "0x7517A40", VA = "0x187519040")]
	public static void KOHMDBDMBDO(DLBBPBLJBPM MMJGFNALDMG, float3 BCCIKKEOOED, [Out] JBAIAMDHOOA MKEHACIMNLP, [Out] float3 LJOPDFJLGBF, [Out] float BPALFEGCDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7518BF0", Offset = "0x75175F0", VA = "0x187518BF0")]
	public static void IHKOONCCELA(Vector3 BCCIKKEOOED, DLBBPBLJBPM MMJGFNALDMG, [Out] Vector3 LJOPDFJLGBF, [Out] float BPALFEGCDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7519310", Offset = "0x7517D10", VA = "0x187519310")]
	[ALOHFLAKNNE(OOMJJAJIPFF.ExitingPlayMode, 0)]
	[LCFFHAAKIME(0)]
	private static void OKDNEHLCCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7519320", Offset = "0x7517D20", VA = "0x187519320")]
	[ALOHFLAKNNE(OOMJJAJIPFF.ExitingPlayMode, 0)]
	[LCFFHAAKIME(0)]
	private static void OOPJPOBIIMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class EHAMCKGINPK : ONKLLCFHLEK, IDisposable, ELAKIILNLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly HOGHJPHDJNN<DLDFPOMGDOP, EDOJPJFJKJA> IPBKNFPMMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly HOGHJPHDJNN<DDLNHDPCINE, MLDHHHFLEPP> GECCPLPADIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly HOGHJPHDJNN<KCNFFJOGDNE, AHLMEOBHIOD> KNIDENBFFMB;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EDOJPJFJKJA MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7517BE0", Offset = "0x75165E0", VA = "0x187517BE0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public MLDHHHFLEPP MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7517C40", Offset = "0x7516640", VA = "0x187517C40", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public AHLMEOBHIOD MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7517B80", Offset = "0x7516580", VA = "0x187517B80", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PEEGDHAFIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FEDF0", Offset = "0x8FD7F0", VA = "0x1808FEDF0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xCE8060", Offset = "0xCE6A60", VA = "0x180CE8060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75183E0", Offset = "0x7516DE0", VA = "0x1875183E0")]
	public EHAMCKGINPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7517CA0", Offset = "0x75166A0", VA = "0x187517CA0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7517D30", Offset = "0x7516730", VA = "0x187517D30", Slot = "4")]
	public DLDFPOMGDOP EJBNCBJEKIC(ONKGMCFPKGJ OIGMDCDEKEG)
	{
		return default(DLDFPOMGDOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7517D30", Offset = "0x7516730", VA = "0x187517D30", Slot = "5")]
	public DLDFPOMGDOP EJBNCBJEKIC(ONKGMCFPKGJ OIGMDCDEKEG, bool EKIGDGPFEPC)
	{
		return default(DLDFPOMGDOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7517E70", Offset = "0x7516870", VA = "0x187517E70", Slot = "6")]
	public void EOECMCBAIKJ(DLDFPOMGDOP MGPJOGDJPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x75179C0", Offset = "0x75163C0", VA = "0x1875179C0", Slot = "7")]
	public void BKHLCINMMEI(DLDFPOMGDOP MGPJOGDJPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7517ED0", Offset = "0x75168D0", VA = "0x187517ED0", Slot = "8")]
	public DDLNHDPCINE HOKIINLNBLJ(DLDFPOMGDOP MGPJOGDJPHA, HKOHCMODGAK OIGMDCDEKEG)
	{
		return default(DDLNHDPCINE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7517A40", Offset = "0x7516440", VA = "0x187517A40", Slot = "9")]
	public DDLNHDPCINE DMPLALIKEPJ(DLDFPOMGDOP MGPJOGDJPHA, AFMNBNBECDC OIGMDCDEKEG)
	{
		return default(DDLNHDPCINE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x75182D0", Offset = "0x7516CD0", VA = "0x1875182D0", Slot = "11")]
	public void PNBCPAFHCGG(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7518010", Offset = "0x7516A10", VA = "0x187518010", Slot = "10")]
	public void IADOHFMCKKH(DDLNHDPCINE OEHDLGBIBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7518070", Offset = "0x7516A70", VA = "0x187518070", Slot = "20")]
	public IEnumerable<Renderer> ILNFFMMKKPE(DLDFPOMGDOP MGPJOGDJPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x75181F0", Offset = "0x7516BF0", VA = "0x1875181F0", Slot = "12")]
	public KCNFFJOGDNE JHPEKKEFFMA(CCBKJCBBPEG OIGMDCDEKEG)
	{
		return default(KCNFFJOGDNE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7518180", Offset = "0x7516B80", VA = "0x187518180", Slot = "14")]
	public void JCFHHDLOHHE(KCNFFJOGDNE CKKGBLDOPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7517DD0", Offset = "0x75167D0", VA = "0x187517DD0", Slot = "16")]
	public Task ENDLDHILDHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x75180E0", Offset = "0x7516AE0", VA = "0x1875180E0", Slot = "17")]
	public Task ILPPECDGBLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7517920", Offset = "0x7516320", VA = "0x187517920", Slot = "18")]
	public Task ALMGDFIKPHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5810", Offset = "0x1FB4210", VA = "0x181FB5810", Slot = "19")]
	public void AICEPEEFDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7518270", Offset = "0x7516C70", VA = "0x187518270", Slot = "13")]
	public void PCJLFKDPNDF(KCNFFJOGDNE CKKGBLDOPHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KKGGNMLOOEG
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DDKFNAIFLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material ACIFJMCHGAK();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material BNIENALMIDH();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material OACEOCKNMIA();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FBKBFDDFLKE(KKGOBCNALDK FMHFHPFEEOH);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int EFPCHLOPKNN(DCLHCFNCEDH JKJOCFNHKGB);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BFGADLPHBHL(GameObject GIGIFGONEAO);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CGNFLJGFOAF(GameObject GIGIFGONEAO, bool DLGCMOJFDFJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BLNEFOKILKE
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static KKGGNMLOOEG BMCAAIIMEIN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool DDKFNAIFLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7514D40", Offset = "0x7513740", VA = "0x187514D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7514DA0", Offset = "0x75137A0", VA = "0x187514DA0")]
	public static void MMIDKOFECIB(KKGGNMLOOEG CIHAOOCJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x75149F0", Offset = "0x75133F0", VA = "0x1875149F0")]
	public static Material ACIFJMCHGAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7514B20", Offset = "0x7513520", VA = "0x187514B20")]
	public static Material BNIENALMIDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7514DF0", Offset = "0x75137F0", VA = "0x187514DF0")]
	public static Material OACEOCKNMIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7514CD0", Offset = "0x75136D0", VA = "0x187514CD0")]
	public static int FBKBFDDFLKE(KKGOBCNALDK FMHFHPFEEOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7514C60", Offset = "0x7513660", VA = "0x187514C60")]
	public static int EFPCHLOPKNN(DCLHCFNCEDH JKJOCFNHKGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7514A50", Offset = "0x7513450", VA = "0x187514A50")]
	public static void BFGADLPHBHL(GameObject GIGIFGONEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7514B80", Offset = "0x7513580", VA = "0x187514B80")]
	public static void CGNFLJGFOAF(GameObject GIGIFGONEAO, bool DLGCMOJFDFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AHLMEOBHIOD : KHIHGMBEOEO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GNNIGFADGPJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public AHLMEOBHIOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x94CA60", Offset = "0x94B460", VA = "0x18094CA60")]
		[DebuggerHidden]
		public GNNIGFADGPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x75199D0", Offset = "0x75183D0", VA = "0x1875199D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x75196B0", Offset = "0x75180B0", VA = "0x1875196B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7519660", Offset = "0x7518060", VA = "0x187519660")]
		private void GPKDFCKBEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7519980", Offset = "0x7518380", VA = "0x187519980", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x75198D0", Offset = "0x75182D0", VA = "0x1875198D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x75198D0", Offset = "0x75182D0", VA = "0x1875198D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly CCBKJCBBPEG DHPMDJCFNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly ELAKIILNLGH IKKHLJONICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EDMJFALBFAP MJBGNOJDGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<GPPGMNNLAKN> FCLDDMBGFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<GPPGMNNLAKN> IINHEHCDIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject EKHELONDGEA;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7514180", Offset = "0x7512B80", VA = "0x187514180")]
	public static AHLMEOBHIOD JFKHIAGIEOI(CCBKJCBBPEG OIGMDCDEKEG, ELAKIILNLGH IKKHLJONICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7514750", Offset = "0x7513150", VA = "0x187514750")]
	private AHLMEOBHIOD(CCBKJCBBPEG OIGMDCDEKEG, ELAKIILNLGH IKKHLJONICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x75142D0", Offset = "0x7512CD0", VA = "0x1875142D0")]
	public void LCECLFEFOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x75133E0", Offset = "0x7511DE0", VA = "0x1875133E0")]
	[IteratorStateMachine(typeof(GNNIGFADGPJ))]
	public IEnumerable<Renderer> BHHAKLFKFPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x75136E0", Offset = "0x75120E0", VA = "0x1875136E0", Slot = "4")]
	public void FNFAALCABCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x75136B0", Offset = "0x75120B0", VA = "0x1875136B0")]
	private void DNKBIPEOOEM(Vector3 JMACEJCBKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7513460", Offset = "0x7511E60", VA = "0x187513460")]
	public void DBMELBLEALE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GPPGMNNLAKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct MJGMBBPNDHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public IEBIJPNOIHK MGOGODPBCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HPFOPEMMFAI AIBEBPFONLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int PPOFBABHCAG;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class AHDNPNJPDIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public GPPGMNNLAKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public KALLCKNDJCE lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<MJGMBBPNDHG> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LCFLAENFPKH combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public AHDNPNJPDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7513350", Offset = "0x7511D50", VA = "0x187513350")]
		internal JobHandle IPJCNOMAGLI()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x75133B0", Offset = "0x7511DB0", VA = "0x1875133B0")]
		internal void JAAGGCMJLIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x75131E0", Offset = "0x7511BE0", VA = "0x1875131E0")]
		internal void DADJGNDABEA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] NMACBIJBAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private PGNFHAPCHPJ DNHFCFDAFNE;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 HDGFIECJAPP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh GLAHKBPOCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int KGFCHDECLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x889410", Offset = "0x887E10", VA = "0x180889410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x889400", Offset = "0x887E00", VA = "0x180889400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7519BD0", Offset = "0x75185D0", VA = "0x187519BD0")]
	public void HNKOONBBMKG(List<HPFOPEMMFAI> DGHMNAIGLLG, Matrix4x4[] GBIMPMGOGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7519DB0", Offset = "0x75187B0", VA = "0x187519DB0")]
	public static List<GPPGMNNLAKN> IFAFEFDLIPC(List<EDOJPJFJKJA> NMIKNAFBBPD, KALLCKNDJCE NDKONLLHKBF, Bounds OBCBNEIIHJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x751A440", Offset = "0x7518E40", VA = "0x18751A440")]
	private JobHandle JHHIECPMLBK(LCFLAENFPKH HOEFHELADNG, int FCPKPFBGPNI, int OJDOODEMIJC, KALLCKNDJCE NDKONLLHKBF, List<MJGMBBPNDHG> MEIGOBPLGDF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x751A7A0", Offset = "0x75191A0", VA = "0x18751A7A0")]
	private void OMCACHNAEHP(List<MJGMBBPNDHG> MEIGOBPLGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x751AA10", Offset = "0x7519410", VA = "0x18751AA10")]
	private GPPGMNNLAKN(List<MJGMBBPNDHG> MEIGOBPLGDF, int FCPKPFBGPNI, int OJDOODEMIJC, KALLCKNDJCE NDKONLLHKBF, Bounds OBCBNEIIHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7519B30", Offset = "0x7518530", VA = "0x187519B30", Slot = "4")]
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
		private MaterialPropertyBlock CHMGEFBPMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private GPPGMNNLAKN ANBKEJJPIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<HPFOPEMMFAI> MBIOIAAEAKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture BBODHNNGDLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer NDKCLDMAIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader NCAFHGNCJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] DFPPFLHNGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int KBNHIAPAFGA;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer LAHNIPJNFAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int NBLLBLOHMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7525660", Offset = "0x7524060", VA = "0x187525660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7524A20", Offset = "0x7523420", VA = "0x187524A20")]
		public static List<SkinnedShapeRenderer> Create(GameObject MGPJOGDJPHA, List<GPPGMNNLAKN> IGECNCLMMFJ, List<HPFOPEMMFAI> MBIOIAAEAKF, Material MLMFHAHBCEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7525040", Offset = "0x7523A40", VA = "0x187525040")]
		public void Init(GPPGMNNLAKN ANBKEJJPIHH, List<HPFOPEMMFAI> MBIOIAAEAKF, Material MLMFHAHBCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x75255C0", Offset = "0x7523FC0", VA = "0x1875255C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7525520", Offset = "0x7523F20", VA = "0x187525520")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x75254E0", Offset = "0x7523EE0", VA = "0x1875254E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7524960", Offset = "0x7523360", VA = "0x187524960")]
		private void ABACNFFHDPD(ScriptableRenderContext GJGBLLHIOAC, Camera[] OIKCLCPOIKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7524CD0", Offset = "0x75236D0", VA = "0x187524CD0")]
		private void HNKOONBBMKG(CommandBuffer JJIFFAIIHCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
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
