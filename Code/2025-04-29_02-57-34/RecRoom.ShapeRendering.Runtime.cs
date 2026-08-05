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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85A5DD0", Offset = "0x85A51D0", VA = "0x1885A5DD0", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD130", Offset = "0x85AC530", VA = "0x1885AD130", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EJABGDKKKFF : PFOENOFFMOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte DLKOOPDCNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] IDOPEJJBFEM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HGEMJEPGAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC46200", Offset = "0xC45600", VA = "0x180C46200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MDIBCDABODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCD7890", Offset = "0xCD6C90", VA = "0x180CD7890", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEBE7C0", Offset = "0xEBDBC0", VA = "0x180EBE7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float PIDGJPKPDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xECB0F0", Offset = "0xECA4F0", VA = "0x180ECB0F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1244090", Offset = "0x1243490", VA = "0x181244090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float GHFKPJBKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBFA4E0", Offset = "0xBF98E0", VA = "0x180BFA4E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBFA4F0", Offset = "0xBF98F0", VA = "0x180BFA4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> HOPLABNPNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x859DDC0", Offset = "0x859D1C0", VA = "0x18859DDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> ALEFNNHPODO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x859DE10", Offset = "0x859D210", VA = "0x18859DE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject IAKDDPPLCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9D24B0", Offset = "0x9D18B0", VA = "0x1809D24B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte MBKECOFCAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x859DE40", Offset = "0x859D240", VA = "0x18859DE40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x859E020", Offset = "0x859D420", VA = "0x18859E020")]
	public EJABGDKKKFF(List<CDNLCEJHJJH> ALOMJLGGFGA, List<CDNLCEJHJJH> JMFGNJJBOEF, List<PLBPIALOLIB> AAPOEDBDHOK, Material FFHFAEDNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x859DA40", Offset = "0x859CE40", VA = "0x18859DA40")]
	private int DEOHHHGPPCC(List<CDNLCEJHJJH> GKNMEGNOFHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x859DC60", Offset = "0x859D060", VA = "0x18859DC60")]
	private void EKMFDDMLCCE(int ODOHNPPOHOG, bool KOIDOLHMLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x859DED0", Offset = "0x859D2D0", VA = "0x18859DED0")]
	public void PCNEPKPMPBD(Vector3 BILKLDHMHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x859DB60", Offset = "0x859CF60", VA = "0x18859DB60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x859DE90", Offset = "0x859D290", VA = "0x18859DE90")]
	public void MPMECFHNFBJ(Transform HPPODIEGHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NNHJJENOMNJ : MDGPOMBODEH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class DBHOOIEELLG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NNHJJENOMNJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public DBHOOIEELLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x859D650", Offset = "0x859CA50", VA = "0x18859D650", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x859D040", Offset = "0x859C440", VA = "0x18859D040", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x859CF50", Offset = "0x859C350", VA = "0x18859CF50")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x859CFF0", Offset = "0x859C3F0", VA = "0x18859CFF0")]
		private void LNCBGHLOKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x859CFA0", Offset = "0x859C3A0", VA = "0x18859CFA0")]
		private void JBBILHDBAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x859D600", Offset = "0x859CA00", VA = "0x18859D600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x859D550", Offset = "0x859C950", VA = "0x18859D550", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x859D550", Offset = "0x859C950", VA = "0x18859D550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class AJJLPCPPGEG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NNHJJENOMNJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public AJJLPCPPGEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x859AAC0", Offset = "0x8599EC0", VA = "0x18859AAC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x859A650", Offset = "0x8599A50", VA = "0x18859A650", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x859A5B0", Offset = "0x85999B0", VA = "0x18859A5B0")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x859A600", Offset = "0x8599A00", VA = "0x18859A600")]
		private void LNCBGHLOKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x859AA70", Offset = "0x8599E70", VA = "0x18859AA70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x859A9C0", Offset = "0x8599DC0", VA = "0x18859A9C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x859A9C0", Offset = "0x8599DC0", VA = "0x18859A9C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly GEHONHPBHEG GEDHHIAHIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<EIGKIPKNFOF> IMNJANACJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> FNOGIGIPOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer BHLIMBJLMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool DDDBKAJHNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool JACPBEMPJJD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<CFLAAKGBDND> GIPMLJFNMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ENEOKJJFPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85A7450", Offset = "0x85A6850", VA = "0x1885A7450", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public PLBPIALOLIB LFHKNHLCPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85A7360", Offset = "0x85A6760", VA = "0x1885A7360", Slot = "8")]
		get
		{
			return default(PLBPIALOLIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> CPFKIPIPNDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9210", Offset = "0x9C8610", VA = "0x1809C9210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85A6E40", Offset = "0x85A6240", VA = "0x1885A6E40")]
	private bool CMIPALOENLF(EIGKIPKNFOF BLJJLAFHKPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85A7430", Offset = "0x85A6830", VA = "0x1885A7430")]
	private static bool HMFCICIKCLE(EIGKIPKNFOF BLJJLAFHKPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85A7CA0", Offset = "0x85A70A0", VA = "0x1885A7CA0")]
	public NNHJJENOMNJ(GEHONHPBHEG AOFGGGKINCN, bool OHBMKFKIJFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85A6EE0", Offset = "0x85A62E0", VA = "0x1885A6EE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85A70D0", Offset = "0x85A64D0", VA = "0x1885A70D0")]
	public void FGAAHPGCDNG(EIGKIPKNFOF BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x85A78D0", Offset = "0x85A6CD0", VA = "0x1885A78D0")]
	public void NMPKBAOEGPN(EIGKIPKNFOF BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x85A6380", Offset = "0x85A5780", VA = "0x1885A6380", Slot = "4")]
	public void BJMOFNLJJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85A75E0", Offset = "0x85A69E0", VA = "0x1885A75E0")]
	public void LFKOACHICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85A7A30", Offset = "0x85A6E30", VA = "0x1885A7A30")]
	private void OJOAOABHABL(List<EIGKIPKNFOF> IMNJANACJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85A5480", Offset = "0x85A4880", VA = "0x1885A5480")]
	private static Material KKJAMFJMAFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85A7BF0", Offset = "0x85A6FF0", VA = "0x1885A7BF0")]
	private void OJOAOABHABL(EIGKIPKNFOF BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x85A7490", Offset = "0x85A6890", VA = "0x1885A7490")]
	private void KOBKAJLCODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x85A6880", Offset = "0x85A5C80", VA = "0x1885A6880")]
	public void CEKMOJJMAME(bool OBKCFGBFBBE, bool MFHLEFHFPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85A72A0", Offset = "0x85A66A0", VA = "0x1885A72A0")]
	protected void FOADABFGCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85A7850", Offset = "0x85A6C50", VA = "0x1885A7850")]
	public void NFFOPLIMIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85A7560", Offset = "0x85A6960", VA = "0x1885A7560")]
	[IteratorStateMachine(typeof(DBHOOIEELLG))]
	public IEnumerable<Renderer> LDALFDKLEBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85A6E60", Offset = "0x85A6260", VA = "0x1885A6E60")]
	[IteratorStateMachine(typeof(AJJLPCPPGEG))]
	public IEnumerable<Renderer> DHLLBFGNBLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class PBFEFIKECPE : EIGKIPKNFOF
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct MLLDLOKFKEM : ACAPGIJOAAC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private EFFDIJJLADK IGPCANDHEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle KAKLANICLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NPEEJPEHNJE LDLGNCNKBNM;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F20", Offset = "0x85A5320", VA = "0x1885A5F20")]
		public MLLDLOKFKEM(EFFDIJJLADK IGPCANDHEAE, JobHandle KAKLANICLFE, NPEEJPEHNJE LDLGNCNKBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85A5EF0", Offset = "0x85A52F0", VA = "0x1885A5EF0", Slot = "4")]
		public EFFDIJJLADK HCGDJHNEKJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85A5EA0", Offset = "0x85A52A0", VA = "0x1885A5EA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly GOBGNEEINFF ICMFOHADIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float CGJMCLGPJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 JBGHMLNNDEN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 CABFEOGJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85A89C0", Offset = "0x85A7DC0", VA = "0x1885A89C0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85A9700", Offset = "0x85A8B00", VA = "0x1885A9700")]
	public PBFEFIKECPE(NNHJJENOMNJ DGFFJNKGDJD, GOBGNEEINFF AOFGGGKINCN, bool OHBMKFKIJFE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "18")]
	public override bool CCIKKPCKEHP(PLBPIALOLIB DGFFJNKGDJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x85A7D90", Offset = "0x85A7190", VA = "0x1885A7D90", Slot = "19")]
	public override int DEOHHHGPPCC(CHLDBBPIOBG BKCGKLBAHGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85A87F0", Offset = "0x85A7BF0", VA = "0x1885A87F0", Slot = "20")]
	public override int HIMJGIFAKHM(CHLDBBPIOBG BKCGKLBAHGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85A8AF0", Offset = "0x85A7EF0", VA = "0x1885A8AF0", Slot = "21")]
	public override ODMOBPPJDNA NAFKPJBGCFH()
	{
		return default(ODMOBPPJDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xBD9320", Offset = "0xBD8720", VA = "0x180BD9320", Slot = "22")]
	public override float KFAJNCDDLMA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85A7F60", Offset = "0x85A7360", VA = "0x1885A7F60", Slot = "23")]
	public override void DILFBCDDEDM(CHLDBBPIOBG BKCGKLBAHGO, PLFGDBMHKGH CADNALAJDNJ, int NCCKAFKAJGC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x85A8560", Offset = "0x85A7960", VA = "0x1885A8560", Slot = "24")]
	public override PLBPIALOLIB EDPNIMOKHHJ()
	{
		return default(PLBPIALOLIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x85A8630", Offset = "0x85A7A30", VA = "0x1885A8630", Slot = "26")]
	public override GBHJFHOOHLF FIFOJEEBKDC()
	{
		return default(GBHJFHOOHLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85A8F30", Offset = "0x85A8330", VA = "0x1885A8F30", Slot = "27")]
	public override ACAPGIJOAAC PJHCPFNFCJC(CHLDBBPIOBG BKCGKLBAHGO, JobHandle KAKLANICLFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface GIKLNFBEAEC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NNHJJENOMNJ LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EIGKIPKNFOF LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ADPMENBPHMM LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class FHEKCOCKKFA : CHLPKMIEKPP, IDisposable, GIKLNFBEAEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KDIEIELDFBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FHEKCOCKKFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85A5630", Offset = "0x85A4A30", VA = "0x1885A5630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85A5BB0", Offset = "0x85A4FB0", VA = "0x1885A5BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly LCKAOPFCAON<POFBMACAHHC, NNHJJENOMNJ> HNLGHPAFFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly LCKAOPFCAON<LAKJFHCHGBH, EIGKIPKNFOF> IMNJANACJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly LCKAOPFCAON<HCOFDHBJAHK, ADPMENBPHMM> OGEFPOOKFIF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NNHJJENOMNJ LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x859F4C0", Offset = "0x859E8C0", VA = "0x18859F4C0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public EIGKIPKNFOF LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x859F520", Offset = "0x859E920", VA = "0x18859F520", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ADPMENBPHMM LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x859F580", Offset = "0x859E980", VA = "0x18859F580", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CNLCFHJDNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD74840", Offset = "0xD73C40", VA = "0x180D74840", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8A0", Offset = "0xA6CCA0", VA = "0x180A6D8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85A05B0", Offset = "0x859F9B0", VA = "0x1885A05B0")]
	public FHEKCOCKKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x859EB00", Offset = "0x859DF00", VA = "0x18859EB00", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x859EF50", Offset = "0x859E350", VA = "0x18859EF50", Slot = "4")]
	public POFBMACAHHC EAKFEALHLCP(GEHONHPBHEG AOFGGGKINCN)
	{
		return default(POFBMACAHHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x859ECD0", Offset = "0x859E0D0", VA = "0x18859ECD0", Slot = "5")]
	public POFBMACAHHC EAKFEALHLCP(GEHONHPBHEG AOFGGGKINCN, bool OHBMKFKIJFE)
	{
		return default(POFBMACAHHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x859E390", Offset = "0x859D790", VA = "0x18859E390", Slot = "6")]
	public void AKBAEDLOKPK(POFBMACAHHC DGFFJNKGDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x859F650", Offset = "0x859EA50", VA = "0x18859F650", Slot = "7")]
	public void NOLLLILCFLG(POFBMACAHHC DGFFJNKGDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x859FA30", Offset = "0x859EE30", VA = "0x18859FA30", Slot = "8")]
	public LAKJFHCHGBH ONLFBDAGEMP(POFBMACAHHC DGFFJNKGDJD, OEONGFIBELC AOFGGGKINCN)
	{
		return default(LAKJFHCHGBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x859FF10", Offset = "0x859F310", VA = "0x18859FF10", Slot = "9")]
	public LAKJFHCHGBH PHOMDLAPEGK(POFBMACAHHC DGFFJNKGDJD, GOBGNEEINFF AOFGGGKINCN)
	{
		return default(LAKJFHCHGBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x859EF60", Offset = "0x859E360", VA = "0x18859EF60", Slot = "11")]
	public void EKNAPFFICDP(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x859E6E0", Offset = "0x859DAE0", VA = "0x18859E6E0", Slot = "10")]
	public void CFOKCOHJIAE(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x859F3F0", Offset = "0x859E7F0", VA = "0x18859F3F0", Slot = "20")]
	public IEnumerable<Renderer> FHPCENCEKCE(POFBMACAHHC DGFFJNKGDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x859F9B0", Offset = "0x859EDB0", VA = "0x18859F9B0", Slot = "12")]
	public HCOFDHBJAHK OEHJCFNPKFP(DCDGHFNBEHP AOFGGGKINCN)
	{
		return default(HCOFDHBJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x859F5E0", Offset = "0x859E9E0", VA = "0x18859F5E0", Slot = "14")]
	public void MCJFIODJCLP(HCOFDHBJAHK JDOFAAAEHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x859E940", Offset = "0x859DD40", VA = "0x18859E940", Slot = "16")]
	public Task DAGPBEIAPAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85A03F0", Offset = "0x859F7F0", VA = "0x1885A03F0", Slot = "17")]
	public Task PPAODIIJFKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x859F320", Offset = "0x859E720", VA = "0x18859F320", Slot = "18")]
	[AsyncStateMachine(typeof(KDIEIELDFBK))]
	public Task FFJBMJMPEEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x859E5F0", Offset = "0x859D9F0", VA = "0x18859E5F0", Slot = "19")]
	public void BJBNEGPGIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x859F460", Offset = "0x859E860", VA = "0x18859F460", Slot = "13")]
	public void HANOEBNGBNE(HCOFDHBJAHK JDOFAAAEHLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class PHLEOCDBJFH : EIGKIPKNFOF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct BAKMNHAMPCA : ACAPGIJOAAC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private EFFDIJJLADK IGPCANDHEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> HLPDPAHBKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle KAKLANICLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EAKADENKGMG LDLGNCNKBNM;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x859ACF0", Offset = "0x859A0F0", VA = "0x18859ACF0")]
		public BAKMNHAMPCA(EFFDIJJLADK IGPCANDHEAE, NativeArray<int> HLPDPAHBKMF, JobHandle KAKLANICLFE, EAKADENKGMG LDLGNCNKBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x859AC90", Offset = "0x859A090", VA = "0x18859AC90", Slot = "4")]
		public EFFDIJJLADK HCGDJHNEKJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x859ABF0", Offset = "0x8599FF0", VA = "0x18859ABF0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly OEONGFIBELC ODKGCMKKMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] PEIOKCDKAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 JBGHMLNNDEN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 ONICMLJKLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85A97B0", Offset = "0x85A8BB0", VA = "0x1885A97B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 CABFEOGJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x85AAA70", Offset = "0x85A9E70", VA = "0x1885AAA70", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x85ABBD0", Offset = "0x85AAFD0", VA = "0x1885ABBD0")]
	public PHLEOCDBJFH(NNHJJENOMNJ DGFFJNKGDJD, OEONGFIBELC AOFGGGKINCN, bool CFNCDLIAMPA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x85A99E0", Offset = "0x85A8DE0", VA = "0x1885A99E0", Slot = "18")]
	public override bool CCIKKPCKEHP(PLBPIALOLIB DGFFJNKGDJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x85AABA0", Offset = "0x85A9FA0", VA = "0x1885AABA0", Slot = "21")]
	public override ODMOBPPJDNA NAFKPJBGCFH()
	{
		return default(ODMOBPPJDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x85AABE0", Offset = "0x85A9FE0", VA = "0x1885AABE0")]
	private ODMOBPPJDNA NAFKPJBGCFH(PLBPIALOLIB DGFFJNKGDJD)
	{
		return default(ODMOBPPJDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x85AB1F0", Offset = "0x85AA5F0", VA = "0x1885AB1F0")]
	private NGIMKCBCGCA OCHJFPJDJGH([In] UniformTRS BLNJEGMAAID, [In] float3 KOLONBMBKAC)
	{
		return default(NGIMKCBCGCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x85A9AB0", Offset = "0x85A8EB0", VA = "0x1885A9AB0", Slot = "19")]
	public override int DEOHHHGPPCC(CHLDBBPIOBG BKCGKLBAHGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x85AA650", Offset = "0x85A9A50", VA = "0x1885AA650", Slot = "20")]
	public override int HIMJGIFAKHM(CHLDBBPIOBG BKCGKLBAHGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x85AA700", Offset = "0x85A9B00", VA = "0x1885AA700", Slot = "22")]
	public override float KFAJNCDDLMA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x85AA7F0", Offset = "0x85A9BF0", VA = "0x1885AA7F0")]
	private int LGJNCODGHFG(CHLDBBPIOBG BKCGKLBAHGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x85A9B60", Offset = "0x85A8F60", VA = "0x1885A9B60", Slot = "23")]
	public override void DILFBCDDEDM(CHLDBBPIOBG BKCGKLBAHGO, PLFGDBMHKGH CADNALAJDNJ, int NCCKAFKAJGC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x85AA3C0", Offset = "0x85A97C0", VA = "0x1885AA3C0", Slot = "24")]
	public override PLBPIALOLIB EDPNIMOKHHJ()
	{
		return default(PLBPIALOLIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x85AA490", Offset = "0x85A9890", VA = "0x1885AA490", Slot = "26")]
	public override GBHJFHOOHLF FIFOJEEBKDC()
	{
		return default(GBHJFHOOHLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x85AB3F0", Offset = "0x85AA7F0", VA = "0x1885AB3F0", Slot = "27")]
	public override ACAPGIJOAAC PJHCPFNFCJC(CHLDBBPIOBG BKCGKLBAHGO, JobHandle KAKLANICLFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface INBGFJLDCIN
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHPMCNBBFIL(NHNCDPLDBOL KHNCICOHHHJ, Renderer JBNKAEBEMAK, int MGPCNEKJBFM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGBDJHIALEJ(Renderer JBNKAEBEMAK, HDJCFKFBNHA GFDPMGHKLOK, Vector3 BNKLIINIGDH, Vector3 DLKJOJJJOLL, Vector3 AGIAACILBAN, float HNACJMNBBOB, float CCPJBOOAHPF, float NOOFMAJNAEA = -1f, [Optional] Color? JLFKDHGAEDA, [Optional] IReadOnlyList<Camera> DFPCLIFINPB);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFAJDFHIKDG(Renderer JBNKAEBEMAK, int MGPCNEKJBFM);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DEBGLAIEFOJ();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GFEHLIKJKFE(int PDEMHAJPPGI, PDIICNIPGKM KHNCICOHHHJ, Renderer JBNKAEBEMAK, int MGPCNEKJBFM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JMDDNLJJANO : GJBDMCKPJAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class FDELLLNDFAE : GMCFILJLLBG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x859E340", Offset = "0x859D740", VA = "0x18859E340")]
		public FDELLLNDFAE(string KCCMEIDBNGP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly INBGFJLDCIN GIPGFAIFNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly GIKLNFBEAEC NGGMJLHELGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer HGMCKPKGCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private FDELLLNDFAE FJKBEPKNFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool ILAABIOAPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer KBDAIIBPNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private FDELLLNDFAE HPLEOOJIABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool OPMCNENKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer LBABCJJLMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private FDELLLNDFAE APDBPEFNEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool BFGLEBCFCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool LLMGCACGBCD;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9CD730", Offset = "0x9CCB30", VA = "0x1809CD730")]
	public JMDDNLJJANO(INBGFJLDCIN KBCIEKPLCPA, GIKLNFBEAEC NGGMJLHELGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x85A3490", Offset = "0x85A2890", VA = "0x1885A3490", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x85A4520", Offset = "0x85A3920", VA = "0x1885A4520")]
	private void NCJPDAFNCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x85A2BA0", Offset = "0x85A1FA0", VA = "0x1885A2BA0", Slot = "4")]
	public void BIFNBMMMHMM(POFBMACAHHC DGFFJNKGDJD, PDIICNIPGKM JPIKKNDHDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x85A2EB0", Offset = "0x85A22B0", VA = "0x1885A2EB0", Slot = "5")]
	public void BIFNBMMMHMM(LAKJFHCHGBH BLJJLAFHKPA, PDIICNIPGKM JPIKKNDHDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x85A3BF0", Offset = "0x85A2FF0", VA = "0x1885A3BF0", Slot = "6")]
	public void INMNMLBJOPG(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x85A3D50", Offset = "0x85A3150", VA = "0x1885A3D50", Slot = "7")]
	public void JFEKFIHJHJM(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x85A3EA0", Offset = "0x85A32A0", VA = "0x1885A3EA0", Slot = "24")]
	public void JOAPGFDODHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x103F100", Offset = "0x103E500", VA = "0x18103F100", Slot = "8")]
	public void IEBLNADDLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x85A31F0", Offset = "0x85A25F0", VA = "0x1885A31F0", Slot = "9")]
	public void DMBPOBGADKI(PDIICNIPGKM JPIKKNDHDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x85A3EE0", Offset = "0x85A32E0", VA = "0x1885A3EE0", Slot = "10")]
	public void KBGJOLNLFJH(POFBMACAHHC DGFFJNKGDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x85A41C0", Offset = "0x85A35C0", VA = "0x1885A41C0", Slot = "11")]
	public void KBGJOLNLFJH(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x85A3640", Offset = "0x85A2A40", VA = "0x1885A3640", Slot = "12")]
	public void HGLHMKLEJDL(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x85A50D0", Offset = "0x85A44D0", VA = "0x1885A50D0", Slot = "13")]
	public void PNGJNHENPBB(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x85A3980", Offset = "0x85A2D80", VA = "0x1885A3980")]
	private void ICGANGIGOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1279CF0", Offset = "0x12790F0", VA = "0x181279CF0", Slot = "14")]
	public void BLMDMJNELFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x85A30D0", Offset = "0x85A24D0", VA = "0x1885A30D0", Slot = "15")]
	public void DDNMGHNPNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x85A27F0", Offset = "0x85A1BF0", VA = "0x1885A27F0", Slot = "16")]
	public void AAIDBFIDPFD(POFBMACAHHC DGFFJNKGDJD, NHNCDPLDBOL KHNCICOHHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x85A2AD0", Offset = "0x85A1ED0", VA = "0x1885A2AD0", Slot = "17")]
	public void AGMFLPGAAKI(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x85A5000", Offset = "0x85A4400", VA = "0x1885A5000", Slot = "18")]
	public void OOENJILALEN(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xC49170", Offset = "0xC48570", VA = "0x180C49170", Slot = "19")]
	public void CHPOHPIKEIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x85A3360", Offset = "0x85A2760", VA = "0x1885A3360", Slot = "20")]
	public void DMHMJAEDLPA(NHNCDPLDBOL KHNCICOHHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x85A3710", Offset = "0x85A2B10", VA = "0x1885A3710")]
	private void HHHBGGFAGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x85A4790", Offset = "0x85A3B90", VA = "0x1885A4790", Slot = "21")]
	public void OKGGLNALBDN(POFBMACAHHC DGFFJNKGDJD, Vector3 BNKLIINIGDH, Vector3 DLKJOJJJOLL, Vector3 AGIAACILBAN, float HNACJMNBBOB, float CCPJBOOAHPF, IReadOnlyList<Camera> DLEMFNDACKP, HDJCFKFBNHA GFDPMGHKLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x85A4B60", Offset = "0x85A3F60", VA = "0x1885A4B60", Slot = "22")]
	public void OKGGLNALBDN(HCOFDHBJAHK JDOFAAAEHLA, Vector3 BNKLIINIGDH, Vector3 DLKJOJJJOLL, Vector3 AGIAACILBAN, float HNACJMNBBOB, float CCPJBOOAHPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class EIGKIPKNFOF : LGGLAOFOIKL, CFLAAKGBDND, MENFNLMPICP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly NNHJJENOMNJ IAKDDPPLCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int IIMDCHGNLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds EHBHGBFAPKM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds ICDGAJCAFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x859D840", Offset = "0x859CC40", VA = "0x18859D840", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool JACPBEMPJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD3A7B0", VA = "0x180D3B3B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD3B000", Offset = "0xD3A400", VA = "0x180D3B000")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 CABFEOGJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PLCOGJEHKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xBB21D0", Offset = "0xBB15D0", VA = "0x180BB21D0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public LDMHMGJPLMC DDIBMKIICNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9C9210", Offset = "0x9C8610", VA = "0x1809C9210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool KIALCPBFOME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xE658E0", Offset = "0xE64CE0", VA = "0x180E658E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	protected EIGKIPKNFOF(NNHJJENOMNJ DGFFJNKGDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x859D890", Offset = "0x859CC90", VA = "0x18859D890", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "18")]
	public virtual bool CCIKKPCKEHP(PLBPIALOLIB DGFFJNKGDJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x859DA30", Offset = "0x859CE30", VA = "0x18859DA30", Slot = "10")]
	public int NCFLKLFENOH(int GMFDEBIMACA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int DEOHHHGPPCC(CHLDBBPIOBG BKCGKLBAHGO);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int HIMJGIFAKHM(CHLDBBPIOBG BKCGKLBAHGO);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract ODMOBPPJDNA NAFKPJBGCFH();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float KFAJNCDDLMA();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void DILFBCDDEDM(CHLDBBPIOBG BKCGKLBAHGO, PLFGDBMHKGH CADNALAJDNJ, int NCCKAFKAJGC = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract PLBPIALOLIB EDPNIMOKHHJ();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x859DA00", Offset = "0x859CE00", VA = "0x18859DA00", Slot = "13")]
	public Hash128 EDOCNNBDGCL(int BKCGKLBAHGO)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract GBHJFHOOHLF FIFOJEEBKDC();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract ACAPGIJOAAC PJHCPFNFCJC(CHLDBBPIOBG BKCGKLBAHGO, JobHandle KAKLANICLFE);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x859D860", Offset = "0x859CC60", VA = "0x18859D860", Slot = "12")]
	public ACAPGIJOAAC DGPDBACCJFI(int BKCGKLBAHGO)
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
		[Cpp2IlInjected.Address(RVA = "0x85ABC80", Offset = "0x85AB080", VA = "0x1885ABC80")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HNOKEMGCAOI
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KMFGLMFGKDF : IEnumerable<AMADKAACINB>, IEnumerable, IEnumerator<AMADKAACINB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private AMADKAACINB <>2__current;

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
		private AMADKAACINB System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public KMFGLMFGKDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x85A5C10", Offset = "0x85A5010", VA = "0x1885A5C10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85A5D80", Offset = "0x85A5180", VA = "0x1885A5D80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x85A5CE0", Offset = "0x85A50E0", VA = "0x1885A5CE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AMADKAACINB> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x85A5CE0", Offset = "0x85A50E0", VA = "0x1885A5CE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static AMADKAACINB[][] BCBHFGNODIB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static NCHCFNFMMPI LFPKCPPDMDK;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig KGIKIEOIHHD;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader NCNBHMOGPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x85A20C0", Offset = "0x85A14C0", VA = "0x1885A20C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer LFLLLDHPBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x85A0F00", Offset = "0x85A0300", VA = "0x1885A0F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x85A0F60", Offset = "0x85A0360", VA = "0x1885A0F60")]
	[GEMHNPPGODB]
	internal static void ENMMELFAOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x85A0C80", Offset = "0x85A0080", VA = "0x1885A0C80")]
	public static Mesh CJGEPHOKIDG(DEPAGOGAGPE HCHBNACEOEO, int BKCGKLBAHGO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x85A2080", Offset = "0x85A1480", VA = "0x1885A2080")]
	public static int INJPAKANNNJ(DEPAGOGAGPE HCHBNACEOEO, int BKCGKLBAHGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x85A0A60", Offset = "0x859FE60", VA = "0x1885A0A60")]
	public static NCHCFNFMMPI BHDPCJJJGHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x85A1050", Offset = "0x85A0450", VA = "0x1885A1050")]
	[IteratorStateMachine(typeof(KMFGLMFGKDF))]
	private static IEnumerable<AMADKAACINB> GKBLDAHHLNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x85A1260", Offset = "0x85A0660", VA = "0x1885A1260")]
	public static AMADKAACINB IKPPDBKNOPE(DEPAGOGAGPE HCHBNACEOEO, int BKCGKLBAHGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x85A2090", Offset = "0x85A1490", VA = "0x1885A2090")]
	public static bool KFIHNAGPLKO(this DEPAGOGAGPE HCHBNACEOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x85A10B0", Offset = "0x85A04B0", VA = "0x1885A10B0")]
	public static void GNCPONIDDIJ(DEPAGOGAGPE HCHBNACEOEO, float3 PMJOGKFGHJK, [Out] ECCJBFKFHGL FJFALCPEGPC, [Out] float3 BICOMGBPLNP, [Out] float DCIKFJOIIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x85A2120", Offset = "0x85A1520", VA = "0x1885A2120")]
	public static void PPDCPEKELGL(Vector3 PMJOGKFGHJK, DEPAGOGAGPE HCHBNACEOEO, [Out] Vector3 BICOMGBPLNP, [Out] float DCIKFJOIIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x85A20B0", Offset = "0x85A14B0", VA = "0x1885A20B0")]
	[DKJBLJOCEDG(0)]
	[ACNGIGGALON(NCEMIMPHJMG.ExitingPlayMode, 0)]
	private static void LFMFIABLDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x85A0D20", Offset = "0x85A0120", VA = "0x1885A0D20")]
	[DKJBLJOCEDG(0)]
	[ACNGIGGALON(NCEMIMPHJMG.ExitingPlayMode, 0)]
	private static void DAAHECENFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class BMMOIABMGNC : CHLPKMIEKPP, IDisposable, GIKLNFBEAEC
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly LCKAOPFCAON<POFBMACAHHC, NNHJJENOMNJ> HNLGHPAFFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LCKAOPFCAON<LAKJFHCHGBH, EIGKIPKNFOF> IMNJANACJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LCKAOPFCAON<HCOFDHBJAHK, ADPMENBPHMM> OGEFPOOKFIF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public NNHJJENOMNJ LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x859B240", Offset = "0x859A640", VA = "0x18859B240", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EIGKIPKNFOF LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x859B2A0", Offset = "0x859A6A0", VA = "0x18859B2A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ADPMENBPHMM LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x859B1E0", Offset = "0x859A5E0", VA = "0x18859B1E0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CNLCFHJDNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xD74840", Offset = "0xD73C40", VA = "0x180D74840", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8A0", Offset = "0xA6CCA0", VA = "0x180A6D8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x859B820", Offset = "0x859AC20", VA = "0x18859B820")]
	public BMMOIABMGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x859AEB0", Offset = "0x859A2B0", VA = "0x18859AEB0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x859AF40", Offset = "0x859A340", VA = "0x18859AF40", Slot = "4")]
	public POFBMACAHHC EAKFEALHLCP(GEHONHPBHEG AOFGGGKINCN)
	{
		return default(POFBMACAHHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x859AF40", Offset = "0x859A340", VA = "0x18859AF40", Slot = "5")]
	public POFBMACAHHC EAKFEALHLCP(GEHONHPBHEG AOFGGGKINCN, bool OHBMKFKIJFE)
	{
		return default(POFBMACAHHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x859AD50", Offset = "0x859A150", VA = "0x18859AD50", Slot = "6")]
	public void AKBAEDLOKPK(POFBMACAHHC DGFFJNKGDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x859B370", Offset = "0x859A770", VA = "0x18859B370", Slot = "7")]
	public void NOLLLILCFLG(POFBMACAHHC DGFFJNKGDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x859B470", Offset = "0x859A870", VA = "0x18859B470", Slot = "8")]
	public LAKJFHCHGBH ONLFBDAGEMP(POFBMACAHHC DGFFJNKGDJD, OEONGFIBELC AOFGGGKINCN)
	{
		return default(LAKJFHCHGBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x859B5B0", Offset = "0x859A9B0", VA = "0x18859B5B0", Slot = "9")]
	public LAKJFHCHGBH PHOMDLAPEGK(POFBMACAHHC DGFFJNKGDJD, GOBGNEEINFF AOFGGGKINCN)
	{
		return default(LAKJFHCHGBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x859AFE0", Offset = "0x859A3E0", VA = "0x18859AFE0", Slot = "11")]
	public void EKNAPFFICDP(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x859ADB0", Offset = "0x859A1B0", VA = "0x18859ADB0", Slot = "10")]
	public void CFOKCOHJIAE(LAKJFHCHGBH BLJJLAFHKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x859B110", Offset = "0x859A510", VA = "0x18859B110", Slot = "20")]
	public IEnumerable<Renderer> FHPCENCEKCE(POFBMACAHHC DGFFJNKGDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x859B3F0", Offset = "0x859A7F0", VA = "0x18859B3F0", Slot = "12")]
	public HCOFDHBJAHK OEHJCFNPKFP(DCDGHFNBEHP AOFGGGKINCN)
	{
		return default(HCOFDHBJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x859B300", Offset = "0x859A700", VA = "0x18859B300", Slot = "14")]
	public void MCJFIODJCLP(HCOFDHBJAHK JDOFAAAEHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x859AE10", Offset = "0x859A210", VA = "0x18859AE10", Slot = "16")]
	public Task DAGPBEIAPAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x859B6F0", Offset = "0x859AAF0", VA = "0x18859B6F0", Slot = "17")]
	public Task PPAODIIJFKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x859B070", Offset = "0x859A470", VA = "0x18859B070", Slot = "18")]
	public Task FFJBMJMPEEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x25FE680", Offset = "0x25FDA80", VA = "0x1825FE680", Slot = "19")]
	public void BJBNEGPGIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x859B180", Offset = "0x859A580", VA = "0x18859B180", Slot = "13")]
	public void HANOEBNGBNE(HCOFDHBJAHK JDOFAAAEHLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IDCIFGFBHPH
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool GCAKLMCFAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material DIMNCICBOOC();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material KKJAMFJMAFB();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material EMMOONJNKCJ();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LICHOMNDDIN(ADLIHGEBFFL PALICIKBOFC);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IGDNOCLENBB(MCPAODJHNLK KIJMDMKIKKC);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NIPPMIMEILN(GameObject KLANNNFBLNB);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ALCNHNNCJBM(GameObject KLANNNFBLNB, bool ECCHLLGICAJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KANDNAMEIKH
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static IDCIFGFBHPH GDOONENKGAE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool GCAKLMCFAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x85A53B0", Offset = "0x85A47B0", VA = "0x1885A53B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x85A52F0", Offset = "0x85A46F0", VA = "0x1885A52F0")]
	public static void EDIPKNOJBBC(IDCIFGFBHPH KPHJJIMEFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x85A5290", Offset = "0x85A4690", VA = "0x1885A5290")]
	public static Material DIMNCICBOOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x85A5480", Offset = "0x85A4880", VA = "0x1885A5480")]
	public static Material KKJAMFJMAFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x85A5350", Offset = "0x85A4750", VA = "0x1885A5350")]
	public static Material EMMOONJNKCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x85A54E0", Offset = "0x85A48E0", VA = "0x1885A54E0")]
	public static int LICHOMNDDIN(ADLIHGEBFFL PALICIKBOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x85A5410", Offset = "0x85A4810", VA = "0x1885A5410")]
	public static int IGDNOCLENBB(MCPAODJHNLK KIJMDMKIKKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x85A5550", Offset = "0x85A4950", VA = "0x1885A5550")]
	public static void NIPPMIMEILN(GameObject KLANNNFBLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x85A51A0", Offset = "0x85A45A0", VA = "0x1885A51A0")]
	public static void ALCNHNNCJBM(GameObject KLANNNFBLNB, bool ECCHLLGICAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ADPMENBPHMM : MDGPOMBODEH
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MMOFIKLFKKC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public ADPMENBPHMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public MMOFIKLFKKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x85A62F0", Offset = "0x85A56F0", VA = "0x1885A62F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x85A5FD0", Offset = "0x85A53D0", VA = "0x1885A5FD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F80", Offset = "0x85A5380", VA = "0x1885A5F80")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x85A62A0", Offset = "0x85A56A0", VA = "0x1885A62A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x85A61F0", Offset = "0x85A55F0", VA = "0x1885A61F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x85A61F0", Offset = "0x85A55F0", VA = "0x1885A61F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DCDGHFNBEHP JCGPNGHKCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GIKLNFBEAEC NGGMJLHELGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private EJABGDKKKFF BNAGBIHJAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<CDNLCEJHJJH> LPEMBFHGHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<CDNLCEJHJJH> MGKEPJEGCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject MMOCHBHOHLE;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x859A0B0", Offset = "0x85994B0", VA = "0x18859A0B0")]
	public static ADPMENBPHMM JGJMNBEBHJE(DCDGHFNBEHP AOFGGGKINCN, GIKLNFBEAEC NGGMJLHELGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x859A4D0", Offset = "0x85998D0", VA = "0x18859A4D0")]
	private ADPMENBPHMM(DCDGHFNBEHP AOFGGGKINCN, GIKLNFBEAEC NGGMJLHELGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8599BF0", Offset = "0x8598FF0", VA = "0x188599BF0")]
	public void BKMLDGFOOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x859A200", Offset = "0x8599600", VA = "0x18859A200")]
	[IteratorStateMachine(typeof(MMOFIKLFKKC))]
	public IEnumerable<Renderer> LDALFDKLEBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8599130", Offset = "0x8598530", VA = "0x188599130", Slot = "4")]
	public void BJMOFNLJJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x859A080", Offset = "0x8599480", VA = "0x18859A080")]
	private void GOBAJBJNJND(Vector3 BILKLDHMHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x859A280", Offset = "0x8599680", VA = "0x18859A280")]
	public void LFKOACHICEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CDNLCEJHJJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct MHFDCNGHNIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public PLFGDBMHKGH IBFLANGKAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public PLBPIALOLIB PHMGMMHLCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int NIOHEDLAJKE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IJEIOBIHIMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public CDNLCEJHJJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CHLDBBPIOBG lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<MHFDCNGHNIJ> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public EFFDIJJLADK combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public IJEIOBIHIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x85A2620", Offset = "0x85A1A20", VA = "0x1885A2620")]
		internal JobHandle DHCBMCCGFFN()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x85A25F0", Offset = "0x85A19F0", VA = "0x1885A25F0")]
		internal void CBPOBNJLAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x85A2680", Offset = "0x85A1A80", VA = "0x1885A2680")]
		internal void FHNMLKPKDOG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] ENDAJOJOCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private GJAGLJKAIDE BFOEFDMHDEA;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 NEDKGIJCELO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh FGNNOJBFLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HBNBJNMIHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9D75F0", Offset = "0x9D69F0", VA = "0x1809D75F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x859C340", Offset = "0x859B740", VA = "0x18859C340")]
	public void FPMNKDGJAJM(List<PLBPIALOLIB> AGKNPKINIKG, Matrix4x4[] BMOBFCOCEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x859BC10", Offset = "0x859B010", VA = "0x18859BC10")]
	public static List<CDNLCEJHJJH> BPKMLDCMEGB(List<NNHJJENOMNJ> OGBPGAPCMKI, CHLDBBPIOBG BKCGKLBAHGO, Bounds ECGIIMPBODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x859C530", Offset = "0x859B930", VA = "0x18859C530")]
	private JobHandle LABLEMCAGOL(EFFDIJJLADK PJNPGNJOFDI, int MIJFEJOJGGN, int OBALFOMMEDB, CHLDBBPIOBG BKCGKLBAHGO, List<MHFDCNGHNIJ> OGNDJPNIIGK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x859C8A0", Offset = "0x859BCA0", VA = "0x18859C8A0")]
	private void OFBIGEOGHGN(List<MHFDCNGHNIJ> OGNDJPNIIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x859CB20", Offset = "0x859BF20", VA = "0x18859CB20")]
	private CDNLCEJHJJH(List<MHFDCNGHNIJ> OGNDJPNIIGK, int MIJFEJOJGGN, int OBALFOMMEDB, CHLDBBPIOBG BKCGKLBAHGO, Bounds ECGIIMPBODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x859C2A0", Offset = "0x859B6A0", VA = "0x18859C2A0", Slot = "4")]
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
		private MaterialPropertyBlock ENIIFPAMLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private CDNLCEJHJJH IGPCANDHEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<PLBPIALOLIB> AAPOEDBDHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture OFEBECDNFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer CGPOJJDIDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader ACPCKBALAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] GMAHHMCEAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int JBLFGGBBNHN;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer OFGFAMBKHKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int AMKFENNOCGF
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x85AC9B0", Offset = "0x85ABDB0", VA = "0x1885AC9B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x85ABDA0", Offset = "0x85AB1A0", VA = "0x1885ABDA0")]
		public static List<SkinnedShapeRenderer> Create(GameObject DGFFJNKGDJD, List<CDNLCEJHJJH> GKNMEGNOFHB, List<PLBPIALOLIB> AAPOEDBDHOK, Material FFHFAEDNMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x85AC3A0", Offset = "0x85AB7A0", VA = "0x1885AC3A0")]
		public void Init(CDNLCEJHJJH IGPCANDHEAE, List<PLBPIALOLIB> AAPOEDBDHOK, Material FFHFAEDNMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x85AC910", Offset = "0x85ABD10", VA = "0x1885AC910")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x85AC870", Offset = "0x85ABC70", VA = "0x1885AC870")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x85AC830", Offset = "0x85ABC30", VA = "0x1885AC830")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x85ABCE0", Offset = "0x85AB0E0", VA = "0x1885ABCE0")]
		private void BENEHLKMJKG(ScriptableRenderContext FAJBNOJIOHK, Camera[] CIJNGEIHNEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x85AC030", Offset = "0x85AB430", VA = "0x1885AC030")]
		private void FPMNKDGJAJM(CommandBuffer MAFGPAKILHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
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
