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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6FE0", Offset = "0x7ED63E0", VA = "0x187ED6FE0", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EE3100", Offset = "0x7EE2500", VA = "0x187EE3100", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class POIKINCNHOI : BFLPMOCJHIK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte HEJBPBNMODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] KJEOHKIHMLH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IELKCBODMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB39280", Offset = "0xB38680", VA = "0x180B39280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MBNLDPKNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98AE60", Offset = "0x98A260", VA = "0x18098AE60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98A4B0", Offset = "0x9898B0", VA = "0x18098A4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float NNOLELLJELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD6CA30", Offset = "0xD6BE30", VA = "0x180D6CA30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1022A20", Offset = "0x1021E20", VA = "0x181022A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CJEAMCILIHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAE5660", Offset = "0xAE4A60", VA = "0x180AE5660", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAE5670", Offset = "0xAE4A70", VA = "0x180AE5670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> CIEPCJONGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1350", Offset = "0x7EE0750", VA = "0x187EE1350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> HAEJNKBAOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE17E0", Offset = "0x7EE0BE0", VA = "0x187EE17E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte JJPCCOLOEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7EE14E0", Offset = "0x7EE08E0", VA = "0x187EE14E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1930", Offset = "0x7EE0D30", VA = "0x187EE1930")]
	public POIKINCNHOI(List<MMJDOJKFJKC> MIGOIDBBCPH, List<MMJDOJKFJKC> FKIEHALJENE, List<LCHJICBNMPB> BLNGGKCOHMF, Material HJCEHLILOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1810", Offset = "0x7EE0C10", VA = "0x187EE1810")]
	private int OOONHBLCKPL(List<MMJDOJKFJKC> MEDHCPCLFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1530", Offset = "0x7EE0930", VA = "0x187EE1530")]
	private void ILIOKNKCCKI(int CNAOCCEHOGI, bool IMLBMCFLIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7EE1690", Offset = "0x7EE0A90", VA = "0x187EE1690")]
	public void KOJBMAHGHGD(Vector3 HLLEBBDLEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7EE13A0", Offset = "0x7EE07A0", VA = "0x187EE13A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7EE14A0", Offset = "0x7EE08A0", VA = "0x187EE14A0")]
	public void EJPEIIKDJJM(Transform GHMAJEPHLEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EGHKOOBHNBK : GAKNKMDFLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class OHIBKMNOLGM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EGHKOOBHNBK <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public OHIBKMNOLGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE890", Offset = "0x7EDDC90", VA = "0x187EDE890", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE280", Offset = "0x7EDD680", VA = "0x187EDE280", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE190", Offset = "0x7EDD590", VA = "0x187EDE190")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE1E0", Offset = "0x7EDD5E0", VA = "0x187EDE1E0")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE230", Offset = "0x7EDD630", VA = "0x187EDE230")]
		private void FCJODFEMCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE840", Offset = "0x7EDDC40", VA = "0x187EDE840", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE790", Offset = "0x7EDDB90", VA = "0x187EDE790", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE790", Offset = "0x7EDDB90", VA = "0x187EDE790", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LGIPLFIMGHN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EGHKOOBHNBK <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public LGIPLFIMGHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6CB0", Offset = "0x7ED60B0", VA = "0x187ED6CB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6840", Offset = "0x7ED5C40", VA = "0x187ED6840", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED67A0", Offset = "0x7ED5BA0", VA = "0x187ED67A0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED67F0", Offset = "0x7ED5BF0", VA = "0x187ED67F0")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6C60", Offset = "0x7ED6060", VA = "0x187ED6C60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6BB0", Offset = "0x7ED5FB0", VA = "0x187ED6BB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6BB0", Offset = "0x7ED5FB0", VA = "0x187ED6BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LIJGIKFJLHJ EHMJINIHOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<LIGBIBGKMNI> NOPAPHLJJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> LNIFMDKNEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer HHNIJPLMAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool CADEECFBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool IIDBNBEANPD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<LOFFCANAFML> EPELPEGDDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JDMNHHPGBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7ED10F0", Offset = "0x7ED04F0", VA = "0x187ED10F0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LCHJICBNMPB MEJHMILJPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED0E50", Offset = "0x7ED0250", VA = "0x187ED0E50", Slot = "8")]
		get
		{
			return default(LCHJICBNMPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> MIJKPLFPKPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x94FAD0", Offset = "0x94EED0", VA = "0x18094FAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED11B0", Offset = "0x7ED05B0", VA = "0x187ED11B0")]
	private bool MMADCLHHCFJ(LIGBIBGKMNI LFCFKCMCBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0040", Offset = "0x7ECF440", VA = "0x187ED0040")]
	private static bool BMMDOMLIOEA(LIGBIBGKMNI LFCFKCMCBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1960", Offset = "0x7ED0D60", VA = "0x187ED1960")]
	public EGHKOOBHNBK(LIJGIKFJLHJ GIDGOODJFLJ, bool OMPOIHMLEAJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0760", Offset = "0x7ECFB60", VA = "0x187ED0760", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0F20", Offset = "0x7ED0320", VA = "0x187ED0F20")]
	public void HBHDBABAKDP(LIGBIBGKMNI LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7ED12A0", Offset = "0x7ED06A0", VA = "0x187ED12A0")]
	public void OCDDHDAHAOD(LIGBIBGKMNI LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0950", Offset = "0x7ECFD50", VA = "0x187ED0950", Slot = "4")]
	public void EOLAGDPNCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1670", Offset = "0x7ED0A70", VA = "0x187ED1670")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1400", Offset = "0x7ED0800", VA = "0x187ED1400")]
	private void OHCHFMGBJFN(List<LIGBIBGKMNI> NOPAPHLJJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFE00", Offset = "0x7ECF200", VA = "0x187ECFE00")]
	private static Material HONNMHOECBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7ED15C0", Offset = "0x7ED09C0", VA = "0x187ED15C0")]
	private void OHCHFMGBJFN(LIGBIBGKMNI LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7ED11D0", Offset = "0x7ED05D0", VA = "0x187ED11D0")]
	private void MMNKHADNKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7ED00E0", Offset = "0x7ECF4E0", VA = "0x187ED00E0")]
	public void DGHHHCJHPFL(bool PHNDGJMLNBL, bool JJDBODNKGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED06A0", Offset = "0x7ECFAA0", VA = "0x187ED06A0")]
	protected void DONKCMHBEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0060", Offset = "0x7ECF460", VA = "0x187ED0060")]
	public void CLHMHAAGGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1130", Offset = "0x7ED0530", VA = "0x187ED1130")]
	[IteratorStateMachine(typeof(OHIBKMNOLGM))]
	public IEnumerable<Renderer> KNPLMAJOPFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED18E0", Offset = "0x7ED0CE0", VA = "0x187ED18E0")]
	[IteratorStateMachine(typeof(LGIPLFIMGHN))]
	public IEnumerable<Renderer> POFICPNGEIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class OKLDIBJBHKM : LIGBIBGKMNI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct AHGEFBIIDML : FGGNJKPDLHJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private FBFDINCPKFI LCGHOEMEOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle NIJHHKONNDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private CDMFKIAEDKP OFNDGACAHPN;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF1D0", Offset = "0x7ECE5D0", VA = "0x187ECF1D0")]
		public AHGEFBIIDML(FBFDINCPKFI LCGHOEMEOEK, JobHandle NIJHHKONNDH, CDMFKIAEDKP OFNDGACAHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF1A0", Offset = "0x7ECE5A0", VA = "0x187ECF1A0", Slot = "4")]
		public FBFDINCPKFI HMABCBLNCNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF150", Offset = "0x7ECE550", VA = "0x187ECF150", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly MIIIGIALJDC BCPJFDEICNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float HGJGPIIHIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 HEIJDIHECJH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 BADNBOCGGNH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFAF0", Offset = "0x7EDEEF0", VA = "0x187EDFAF0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7EE03E0", Offset = "0x7EDF7E0", VA = "0x187EE03E0")]
	public OKLDIBJBHKM(EGHKOOBHNBK JGHOOBNHEJB, MIIIGIALJDC GIDGOODJFLJ, bool OMPOIHMLEAJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "18")]
	public override bool MKNJJOFADEL(LCHJICBNMPB JGHOOBNHEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0210", Offset = "0x7EDF610", VA = "0x187EE0210", Slot = "19")]
	public override int OOONHBLCKPL(NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF920", Offset = "0x7EDED20", VA = "0x187EDF920", Slot = "20")]
	public override int IMAMFLJKHIL(NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF4E0", Offset = "0x7EDE8E0", VA = "0x187EDF4E0", Slot = "21")]
	public override DJOEGFIEAIG IICEDMGKFFF()
	{
		return default(DJOEGFIEAIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xAAA430", Offset = "0xAA9830", VA = "0x180AAA430", Slot = "22")]
	public override float LLOMFPLMHGG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7EDFC20", Offset = "0x7EDF020", VA = "0x187EDFC20", Slot = "23")]
	public override void OOEKFELFHKF(NNLGOHCCLAH GNAJNFCKONF, AIIDIKHPDOL EALLMICPGEN, int NILELNIMHMO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7EDF410", Offset = "0x7EDE810", VA = "0x187EDF410", Slot = "24")]
	public override LCHJICBNMPB HCAOBHMHALE()
	{
		return default(LCHJICBNMPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7EDEA80", Offset = "0x7EDDE80", VA = "0x187EDEA80", Slot = "26")]
	public override JCMJGMDLFJF DOJPJOCGEBJ()
	{
		return default(JCMJGMDLFJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7EDEC40", Offset = "0x7EDE040", VA = "0x187EDEC40", Slot = "27")]
	public override FGGNJKPDLHJ GOBJOLFFAJL(NNLGOHCCLAH GNAJNFCKONF, JobHandle NIJHHKONNDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface IFIJOBDPIGK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EGHKOOBHNBK NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	LIGBIBGKMNI NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MMAIIDJOPMJ NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class HDMBGLIIDIO : JIMDDOODGGB, IDisposable, IFIJOBDPIGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BBKIMKHKLAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public HDMBGLIIDIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF230", Offset = "0x7ECE630", VA = "0x187ECF230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF7B0", Offset = "0x7ECEBB0", VA = "0x187ECF7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly CMGKHFLMPCH<DGKNAAFCKEM, EGHKOOBHNBK> DEPDJCCHENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly CMGKHFLMPCH<EEGJHJCMEBL, LIGBIBGKMNI> NOPAPHLJJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly CMGKHFLMPCH<MDKOADIDEPC, MMAIIDJOPMJ> LMIGCOJBOFD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EGHKOOBHNBK NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2FF0", Offset = "0x7ED23F0", VA = "0x187ED2FF0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public LIGBIBGKMNI NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2F90", Offset = "0x7ED2390", VA = "0x187ED2F90", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MMAIIDJOPMJ NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2F30", Offset = "0x7ED2330", VA = "0x187ED2F30", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool HLNLNNLFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC81F60", Offset = "0xC81360", VA = "0x180C81F60", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC81E50", Offset = "0xC81250", VA = "0x180C81E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3C70", Offset = "0x7ED3070", VA = "0x187ED3C70")]
	public HDMBGLIIDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2410", Offset = "0x7ED1810", VA = "0x187ED2410", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED32D0", Offset = "0x7ED26D0", VA = "0x187ED32D0", Slot = "4")]
	public DGKNAAFCKEM LECFEEGHGFO(LIJGIKFJLHJ GIDGOODJFLJ)
	{
		return default(DGKNAAFCKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3050", Offset = "0x7ED2450", VA = "0x187ED3050", Slot = "5")]
	public DGKNAAFCKEM LECFEEGHGFO(LIJGIKFJLHJ GIDGOODJFLJ, bool OMPOIHMLEAJ)
	{
		return default(DGKNAAFCKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1A50", Offset = "0x7ED0E50", VA = "0x187ED1A50", Slot = "6")]
	public void AEFEIDCAEMJ(DGKNAAFCKEM JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1D10", Offset = "0x7ED1110", VA = "0x187ED1D10", Slot = "7")]
	public void BECJIHFLKFF(DGKNAAFCKEM JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2A50", Offset = "0x7ED1E50", VA = "0x187ED2A50", Slot = "8")]
	public EEGJHJCMEBL IDGPMNHFJPC(DGKNAAFCKEM JGHOOBNHEJB, GGPLGOGDNFL GIDGOODJFLJ)
	{
		return default(EEGJHJCMEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3360", Offset = "0x7ED2760", VA = "0x187ED3360", Slot = "9")]
	public EEGJHJCMEBL MHIODBIACKH(DGKNAAFCKEM JGHOOBNHEJB, MIIIGIALJDC GIDGOODJFLJ)
	{
		return default(EEGJHJCMEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3840", Offset = "0x7ED2C40", VA = "0x187ED3840", Slot = "11")]
	public void NHEDDCGKKDL(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7ED21B0", Offset = "0x7ED15B0", VA = "0x187ED21B0", Slot = "10")]
	public void DPFAHEDNFKP(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3C00", Offset = "0x7ED3000", VA = "0x187ED3C00", Slot = "20")]
	public IEnumerable<Renderer> PEEAEAFPGBE(DGKNAAFCKEM JGHOOBNHEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7ED32E0", Offset = "0x7ED26E0", VA = "0x187ED32E0", Slot = "12")]
	public MDKOADIDEPC MFNIMEIGABP(IBEKEEPBPDF GIDGOODJFLJ)
	{
		return default(MDKOADIDEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2140", Offset = "0x7ED1540", VA = "0x187ED2140", Slot = "14")]
	public void BNIFBBPPMNC(MDKOADIDEPC OEJFCMJKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7ED26D0", Offset = "0x7ED1AD0", VA = "0x187ED26D0", Slot = "16")]
	public Task ECNFKAOMLMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2890", Offset = "0x7ED1C90", VA = "0x187ED2890", Slot = "17")]
	public Task FKBAAGJCFKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2070", Offset = "0x7ED1470", VA = "0x187ED2070", Slot = "18")]
	[AsyncStateMachine(typeof(BBKIMKHKLAK))]
	public Task BIJDBGPKDAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7ED25E0", Offset = "0x7ED19E0", VA = "0x187ED25E0", Slot = "19")]
	public void ECMDOCJBIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1CB0", Offset = "0x7ED10B0", VA = "0x187ED1CB0", Slot = "13")]
	public void BCCEFFDAOBD(MDKOADIDEPC OEJFCMJKFFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class KCKDPHBANLP : LIGBIBGKMNI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct CMCILIMAACP : FGGNJKPDLHJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private FBFDINCPKFI LCGHOEMEOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> JOLIFHDDFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle NIJHHKONNDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private GFIHIHGEMHO OFNDGACAHPN;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFB10", Offset = "0x7ECEF10", VA = "0x187ECFB10")]
		public CMCILIMAACP(FBFDINCPKFI LCGHOEMEOEK, NativeArray<int> JOLIFHDDFMM, JobHandle NIJHHKONNDH, GFIHIHGEMHO OFNDGACAHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFAB0", Offset = "0x7ECEEB0", VA = "0x187ECFAB0", Slot = "4")]
		public FBFDINCPKFI HMABCBLNCNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFA10", Offset = "0x7ECEE10", VA = "0x187ECFA10", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly GGPLGOGDNFL FENODPMPHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] FMCMDFPPDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 HEIJDIHECJH;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 JBFJMJKLKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5000", Offset = "0x7ED4400", VA = "0x187ED5000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 BADNBOCGGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7ED5930", Offset = "0x7ED4D30", VA = "0x187ED5930", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6530", Offset = "0x7ED5930", VA = "0x187ED6530")]
	public KCKDPHBANLP(EGHKOOBHNBK JGHOOBNHEJB, GGPLGOGDNFL GIDGOODJFLJ, bool IKBPPKMOIMF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5B50", Offset = "0x7ED4F50", VA = "0x187ED5B50", Slot = "18")]
	public override bool MKNJJOFADEL(LCHJICBNMPB JGHOOBNHEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5840", Offset = "0x7ED4C40", VA = "0x187ED5840", Slot = "21")]
	public override DJOEGFIEAIG IICEDMGKFFF()
	{
		return default(DJOEGFIEAIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5230", Offset = "0x7ED4630", VA = "0x187ED5230")]
	private DJOEGFIEAIG IICEDMGKFFF(LCHJICBNMPB JGHOOBNHEJB)
	{
		return default(DJOEGFIEAIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4120", Offset = "0x7ED3520", VA = "0x187ED4120")]
	private MKCHKHONKEK AMADBEIAKKI([In] UniformTRS GOPPDMAABGE, [In] float3 IGOKMENAGDH)
	{
		return default(MKCHKHONKEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6480", Offset = "0x7ED5880", VA = "0x187ED6480", Slot = "19")]
	public override int OOONHBLCKPL(NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5880", Offset = "0x7ED4C80", VA = "0x187ED5880", Slot = "20")]
	public override int IMAMFLJKHIL(NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5A60", Offset = "0x7ED4E60", VA = "0x187ED5A60", Slot = "22")]
	public override float LLOMFPLMHGG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4CB0", Offset = "0x7ED40B0", VA = "0x187ED4CB0")]
	private int GOKPDDADBAE(NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5C20", Offset = "0x7ED5020", VA = "0x187ED5C20", Slot = "23")]
	public override void OOEKFELFHKF(NNLGOHCCLAH GNAJNFCKONF, AIIDIKHPDOL EALLMICPGEN, int NILELNIMHMO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4F30", Offset = "0x7ED4330", VA = "0x187ED4F30", Slot = "24")]
	public override LCHJICBNMPB HCAOBHMHALE()
	{
		return default(LCHJICBNMPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4320", Offset = "0x7ED3720", VA = "0x187ED4320", Slot = "26")]
	public override JCMJGMDLFJF DOJPJOCGEBJ()
	{
		return default(JCMJGMDLFJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED44E0", Offset = "0x7ED38E0", VA = "0x187ED44E0", Slot = "27")]
	public override FGGNJKPDLHJ GOBJOLFFAJL(NNLGOHCCLAH GNAJNFCKONF, JobHandle NIJHHKONNDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ACMNLEILIEG
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPOJJDNHONK(MDOKODFBGBL BMIPLDLMPCD, Renderer EHMEICJAGNO, int LHKPAPHPDGE);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHJDDGMGFFL(Renderer EHMEICJAGNO, JKMBBDPLCIH OEIGHBFCMEO, Vector3 NCMGFAIKAJI, Vector3 IMLCMDAJDCN, Vector3 GIBOOHLHGPF, float NMNOINHHBAP, float KNKFMCLLNFN, float HBCOCCMPFPE = -1f, [Optional] Color? NHCBHMJDLHA, [Optional] IReadOnlyList<Camera> AAHCGIGOJPL);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFNBOELKFMG(Renderer EHMEICJAGNO, int LHKPAPHPDGE);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CHCPBILMHLD();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNEOPJHNNKJ(int IABMFNODIKM, FFCHMNNCDPE BMIPLDLMPCD, Renderer EHMEICJAGNO, int LHKPAPHPDGE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MNMFLBHOHEB : LNJLGFCNCEA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class EDMIKLENCAB : CKDKINEBKLB<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFFF0", Offset = "0x7ECF3F0", VA = "0x187ECFFF0")]
		public EDMIKLENCAB(string OMOOEGOLALI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly ACMNLEILIEG BJEDFPECLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly IFIJOBDPIGK GEBLLCFNKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer FJJCDFHEOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EDMIKLENCAB NLIIKBHAGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool FMDDLINCLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer AMJIJPFNCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EDMIKLENCAB AAPDAKMOEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool MPGJJDFCGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer KNAKMJLCDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EDMIKLENCAB MGEHHJEDOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool BMOCOGADINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool NLNPPHMOFNH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x957D80", Offset = "0x957180", VA = "0x180957D80")]
	public MNMFLBHOHEB(ACMNLEILIEG EELACOIEKHA, IFIJOBDPIGK GEBLLCFNKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7EDA2F0", Offset = "0x7ED96F0", VA = "0x187EDA2F0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7EDA4A0", Offset = "0x7ED98A0", VA = "0x187EDA4A0")]
	private void ELIJOHCEKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9C70", Offset = "0x7ED9070", VA = "0x187ED9C70", Slot = "4")]
	public void CGFBAPGPBML(DGKNAAFCKEM JGHOOBNHEJB, FFCHMNNCDPE BANIDBBGDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9F80", Offset = "0x7ED9380", VA = "0x187ED9F80", Slot = "5")]
	public void CGFBAPGPBML(EEGJHJCMEBL LFCFKCMCBCB, FFCHMNNCDPE BANIDBBGDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7EDB3F0", Offset = "0x7EDA7F0", VA = "0x187EDB3F0", Slot = "6")]
	public void NDOKGNLMCFH(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7EDA1A0", Offset = "0x7ED95A0", VA = "0x187EDA1A0", Slot = "7")]
	public void DDHOPDHDIKK(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7EDB550", Offset = "0x7EDA950", VA = "0x187EDB550", Slot = "24")]
	public void OCBGOHOEKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xEC2920", Offset = "0xEC1D20", VA = "0x180EC2920", Slot = "8")]
	public void INMGJNLANCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7EDAB20", Offset = "0x7ED9F20", VA = "0x187EDAB20", Slot = "9")]
	public void IMDJAAPNKBM(FFCHMNNCDPE BANIDBBGDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7EDAC90", Offset = "0x7EDA090", VA = "0x187EDAC90", Slot = "10")]
	public void LMAIBOOHJBD(DGKNAAFCKEM JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7EDAF60", Offset = "0x7EDA360", VA = "0x187EDAF60", Slot = "11")]
	public void LMAIBOOHJBD(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9BA0", Offset = "0x7ED8FA0", VA = "0x187ED9BA0", Slot = "12")]
	public void CDECFIAEKHN(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7EDA710", Offset = "0x7ED9B10", VA = "0x187EDA710", Slot = "13")]
	public void FJPCKAONCBJ(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7EDA8B0", Offset = "0x7ED9CB0", VA = "0x187EDA8B0")]
	private void HDECMPCPDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x11204E0", Offset = "0x111F8E0", VA = "0x1811204E0", Slot = "14")]
	public void FIJKHFOPMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7EDB870", Offset = "0x7EDAC70", VA = "0x187EDB870", Slot = "15")]
	public void OPBGNHAIBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7EDB590", Offset = "0x7EDA990", VA = "0x187EDB590", Slot = "16")]
	public void OGNANCMJPAP(DGKNAAFCKEM JGHOOBNHEJB, MDOKODFBGBL BMIPLDLMPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9860", Offset = "0x7ED8C60", VA = "0x187ED9860", Slot = "17")]
	public void AAJGNBPGGLE(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7EDA7E0", Offset = "0x7ED9BE0", VA = "0x187EDA7E0", Slot = "18")]
	public void FOHCAFGBAOM(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xB433E0", Offset = "0xB427E0", VA = "0x180B433E0", Slot = "19")]
	public void IGFDEMDADNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7EDB2C0", Offset = "0x7EDA6C0", VA = "0x187EDB2C0", Slot = "20")]
	public void MKNLHEEPNAI(MDOKODFBGBL BMIPLDLMPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9930", Offset = "0x7ED8D30", VA = "0x187ED9930")]
	private void AFPPMHGGOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7EDBE30", Offset = "0x7EDB230", VA = "0x187EDBE30", Slot = "21")]
	public void OPCOFKAIJBF(DGKNAAFCKEM JGHOOBNHEJB, Vector3 NCMGFAIKAJI, Vector3 IMLCMDAJDCN, Vector3 GIBOOHLHGPF, float NMNOINHHBAP, float KNKFMCLLNFN, IReadOnlyList<Camera> MFLLGDBFINI, JKMBBDPLCIH OEIGHBFCMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7EDB990", Offset = "0x7EDAD90", VA = "0x187EDB990", Slot = "22")]
	public void OPCOFKAIJBF(MDKOADIDEPC OEJFCMJKFFJ, Vector3 NCMGFAIKAJI, Vector3 IMLCMDAJDCN, Vector3 GIBOOHLHGPF, float NMNOINHHBAP, float KNKFMCLLNFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class LIGBIBGKMNI : EJOALOBPCHE, LOFFCANAFML, AGLBPEIFILM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly EGHKOOBHNBK HAMMPINBCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int MFHIAANBFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds GOJJAEDDFCD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds GGLGNDMHGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6FC0", Offset = "0x7ED63C0", VA = "0x187ED6FC0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool IIDBNBEANPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC0A6E0", Offset = "0xC09AE0", VA = "0x180C0A6E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC0A7F0", Offset = "0xC09BF0", VA = "0x180C0A7F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 BADNBOCGGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BCLEHMAPLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC50", Offset = "0xA6B050", VA = "0x180A6BC50", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public AEOFEDMEIPE LCKICDFPPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x94FAD0", Offset = "0x94EED0", VA = "0x18094FAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool KLIBABDMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xD21DA0", Offset = "0xD211A0", VA = "0x180D21DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	protected LIGBIBGKMNI(EGHKOOBHNBK JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6E20", Offset = "0x7ED6220", VA = "0x187ED6E20", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "18")]
	public virtual bool MKNJJOFADEL(LCHJICBNMPB JGHOOBNHEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6DE0", Offset = "0x7ED61E0", VA = "0x187ED6DE0", Slot = "10")]
	public int AJDBIFDLPLB(int GNKBPAECFCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int OOONHBLCKPL(NNLGOHCCLAH GNAJNFCKONF);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int IMAMFLJKHIL(NNLGOHCCLAH GNAJNFCKONF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract DJOEGFIEAIG IICEDMGKFFF();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float LLOMFPLMHGG();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void OOEKFELFHKF(NNLGOHCCLAH GNAJNFCKONF, AIIDIKHPDOL EALLMICPGEN, int NILELNIMHMO = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract LCHJICBNMPB HCAOBHMHALE();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6F90", Offset = "0x7ED6390", VA = "0x187ED6F90", Slot = "13")]
	public Hash128 HOMLBPOJOGN(int GNAJNFCKONF)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract JCMJGMDLFJF DOJPJOCGEBJ();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract FGGNJKPDLHJ GOBJOLFFAJL(NNLGOHCCLAH GNAJNFCKONF, JobHandle NIJHHKONNDH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6DF0", Offset = "0x7ED61F0", VA = "0x187ED6DF0", Slot = "12")]
	public FGGNJKPDLHJ DOAALOHHNEB(int GNAJNFCKONF)
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
		[Cpp2IlInjected.Address(RVA = "0x7EE1C50", Offset = "0x7EE1050", VA = "0x187EE1C50")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OCDDGKDHEPB
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LBEJGAKJDEG : IEnumerable<BFKPFEOEFPC>, IEnumerable, IEnumerator<BFKPFEOEFPC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private BFKPFEOEFPC <>2__current;

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
		private BFKPFEOEFPC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public LBEJGAKJDEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7ED65E0", Offset = "0x7ED59E0", VA = "0x187ED65E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6750", Offset = "0x7ED5B50", VA = "0x187ED6750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED66B0", Offset = "0x7ED5AB0", VA = "0x187ED66B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BFKPFEOEFPC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7ED66B0", Offset = "0x7ED5AB0", VA = "0x187ED66B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static BFKPFEOEFPC[][] EEMDKDFIJME;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static LHIMPKGNCEC HMHKLLGNKNG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig IFNAHBIJNLL;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader NMMEELNLEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC660", Offset = "0x7EDBA60", VA = "0x187EDC660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer KFDMAADKCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC600", Offset = "0x7EDBA00", VA = "0x187EDC600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCC70", Offset = "0x7EDC070", VA = "0x187EDCC70")]
	[ONDAMKAMKDB]
	internal static void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCF20", Offset = "0x7EDC320", VA = "0x187EDCF20")]
	public static Mesh MAEIKHELAAN(OMANHOCOLNE EABCDIJJBLA, int GNAJNFCKONF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCF10", Offset = "0x7EDC310", VA = "0x187EDCF10")]
	public static int LIPOJJAOPAD(OMANHOCOLNE EABCDIJJBLA, int GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCFF0", Offset = "0x7EDC3F0", VA = "0x187EDCFF0")]
	public static LHIMPKGNCEC NDAIOMKKFEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7EDE030", Offset = "0x7EDD430", VA = "0x187EDE030")]
	[IteratorStateMachine(typeof(LBEJGAKJDEG))]
	private static IEnumerable<BFKPFEOEFPC> OMFJGLEDLFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7EDD210", Offset = "0x7EDC610", VA = "0x187EDD210")]
	public static BFKPFEOEFPC NKEBIDOLAGJ(OMANHOCOLNE EABCDIJJBLA, int GNAJNFCKONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCFC0", Offset = "0x7EDC3C0", VA = "0x187EDCFC0")]
	public static bool MJCKIBCEGEI(this OMANHOCOLNE EABCDIJJBLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCD60", Offset = "0x7EDC160", VA = "0x187EDCD60")]
	public static void KJONAJDJOAC(OMANHOCOLNE EABCDIJJBLA, float3 IEBDAOEEHDK, [Out] EKABDFAIFNM BDMOAALHBKO, [Out] float3 PMMPGHCFKMA, [Out] float CJDKGDBGDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7EDC6C0", Offset = "0x7EDBAC0", VA = "0x187EDC6C0")]
	public static void DPBMOLBDJOG(Vector3 IEBDAOEEHDK, OMANHOCOLNE EABCDIJJBLA, [Out] Vector3 PMMPGHCFKMA, [Out] float CJDKGDBGDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCFE0", Offset = "0x7EDC3E0", VA = "0x187EDCFE0")]
	[FBDKNMPMDID(0)]
	[JBPLEELDMPC(GALPNODIPPP.ExitingPlayMode, 0)]
	private static void MKEDLLGPABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7EDCA90", Offset = "0x7EDBE90", VA = "0x187EDCA90")]
	[FBDKNMPMDID(0)]
	[JBPLEELDMPC(GALPNODIPPP.ExitingPlayMode, 0)]
	private static void GEEPMJNCFPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class PGBFEJMGNOJ : JIMDDOODGGB, IDisposable, IFIJOBDPIGK
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly CMGKHFLMPCH<DGKNAAFCKEM, EGHKOOBHNBK> DEPDJCCHENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly CMGKHFLMPCH<EEGJHJCMEBL, LIGBIBGKMNI> NOPAPHLJJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly CMGKHFLMPCH<MDKOADIDEPC, MMAIIDJOPMJ> LMIGCOJBOFD;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public EGHKOOBHNBK NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0A50", Offset = "0x7EDFE50", VA = "0x187EE0A50", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public LIGBIBGKMNI NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0B10", Offset = "0x7EDFF10", VA = "0x187EE0B10", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public MMAIIDJOPMJ NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0AB0", Offset = "0x7EDFEB0", VA = "0x187EE0AB0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HLNLNNLFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xC81F60", Offset = "0xC81360", VA = "0x180C81F60", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC81E50", Offset = "0xC81250", VA = "0x180C81E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0F60", Offset = "0x7EE0360", VA = "0x187EE0F60")]
	public PGBFEJMGNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0740", Offset = "0x7EDFB40", VA = "0x187EE0740", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0B70", Offset = "0x7EDFF70", VA = "0x187EE0B70", Slot = "4")]
	public DGKNAAFCKEM LECFEEGHGFO(LIJGIKFJLHJ GIDGOODJFLJ)
	{
		return default(DGKNAAFCKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0B70", Offset = "0x7EDFF70", VA = "0x187EE0B70", Slot = "5")]
	public DGKNAAFCKEM LECFEEGHGFO(LIJGIKFJLHJ GIDGOODJFLJ, bool OMPOIHMLEAJ)
	{
		return default(DGKNAAFCKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0490", Offset = "0x7EDF890", VA = "0x187EE0490", Slot = "6")]
	public void AEFEIDCAEMJ(DGKNAAFCKEM JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0550", Offset = "0x7EDF950", VA = "0x187EE0550", Slot = "7")]
	public void BECJIHFLKFF(DGKNAAFCKEM JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0910", Offset = "0x7EDFD10", VA = "0x187EE0910", Slot = "8")]
	public EEGJHJCMEBL IDGPMNHFJPC(DGKNAAFCKEM JGHOOBNHEJB, GGPLGOGDNFL GIDGOODJFLJ)
	{
		return default(EEGJHJCMEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0C90", Offset = "0x7EE0090", VA = "0x187EE0C90", Slot = "9")]
	public EEGJHJCMEBL MHIODBIACKH(DGKNAAFCKEM JGHOOBNHEJB, MIIIGIALJDC GIDGOODJFLJ)
	{
		return default(EEGJHJCMEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0DD0", Offset = "0x7EE01D0", VA = "0x187EE0DD0", Slot = "11")]
	public void NHEDDCGKKDL(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EE06E0", Offset = "0x7EDFAE0", VA = "0x187EE06E0", Slot = "10")]
	public void DPFAHEDNFKP(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0E60", Offset = "0x7EE0260", VA = "0x187EE0E60", Slot = "20")]
	public IEnumerable<Renderer> PEEAEAFPGBE(DGKNAAFCKEM JGHOOBNHEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0C10", Offset = "0x7EE0010", VA = "0x187EE0C10", Slot = "12")]
	public MDKOADIDEPC MFNIMEIGABP(IBEKEEPBPDF GIDGOODJFLJ)
	{
		return default(MDKOADIDEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0670", Offset = "0x7EDFA70", VA = "0x187EE0670", Slot = "14")]
	public void BNIFBBPPMNC(MDKOADIDEPC OEJFCMJKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7EE07D0", Offset = "0x7EDFBD0", VA = "0x187EE07D0", Slot = "16")]
	public Task ECNFKAOMLMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7EE0870", Offset = "0x7EDFC70", VA = "0x187EE0870", Slot = "17")]
	public Task FKBAAGJCFKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EE05D0", Offset = "0x7EDF9D0", VA = "0x187EE05D0", Slot = "18")]
	public Task BIJDBGPKDAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2459230", Offset = "0x2458630", VA = "0x182459230", Slot = "19")]
	public void ECMDOCJBIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7EE04F0", Offset = "0x7EDF8F0", VA = "0x187EE04F0", Slot = "13")]
	public void BCCEFFDAOBD(MDKOADIDEPC OEJFCMJKFFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CEEKKJJLJDG
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool BGFIMENPHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KKKNGJEHJPK();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material HONNMHOECBM();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material NHIHBBGKNFK();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MNFCBCDHMFA(MONBNMPFMMO FEIBMFKLDKE);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DABEJAOLCDF(CEHJAJCAOIA KANJCAGIGJK);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HJOLBKHGEPK(GameObject GMFKPONAANG);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DLJJBKPKFLO(GameObject GMFKPONAANG, bool MIKHFDELHDD);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CNPFAFAFMLK
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static CEEKKJJLJDG AAMBBOLAGCO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool BGFIMENPHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFB70", Offset = "0x7ECEF70", VA = "0x187ECFB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFEC0", Offset = "0x7ECF2C0", VA = "0x187ECFEC0")]
	public static void LEFOFLNEOOO(CEEKKJJLJDG PKBEMFNNIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFE60", Offset = "0x7ECF260", VA = "0x187ECFE60")]
	public static Material KKKNGJEHJPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFE00", Offset = "0x7ECF200", VA = "0x187ECFE00")]
	public static Material HONNMHOECBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFF90", Offset = "0x7ECF390", VA = "0x187ECFF90")]
	public static Material NHIHBBGKNFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFF20", Offset = "0x7ECF320", VA = "0x187ECFF20")]
	public static int MNFCBCDHMFA(MONBNMPFMMO FEIBMFKLDKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFBD0", Offset = "0x7ECEFD0", VA = "0x187ECFBD0")]
	public static int DABEJAOLCDF(CEHJAJCAOIA KANJCAGIGJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFD30", Offset = "0x7ECF130", VA = "0x187ECFD30")]
	public static void HJOLBKHGEPK(GameObject GMFKPONAANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFC40", Offset = "0x7ECF040", VA = "0x187ECFC40")]
	public static void DLJJBKPKFLO(GameObject GMFKPONAANG, bool MIKHFDELHDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MMAIIDJOPMJ : GAKNKMDFLHA
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NMHBLPBNKPK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public MMAIIDJOPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public NMHBLPBNKPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC570", Offset = "0x7EDB970", VA = "0x187EDC570", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC250", Offset = "0x7EDB650", VA = "0x187EDC250", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC200", Offset = "0x7EDB600", VA = "0x187EDC200")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC520", Offset = "0x7EDB920", VA = "0x187EDC520", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC470", Offset = "0x7EDB870", VA = "0x187EDC470", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC470", Offset = "0x7EDB870", VA = "0x187EDC470", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IBEKEEPBPDF ALEANLPMNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IFIJOBDPIGK GEBLLCFNKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private POIKINCNHOI LMGHPMPGNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<MMJDOJKFJKC> OEKOPHCOBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<MMJDOJKFJKC> NCNILLCBBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject KGPCOFHLLIJ;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8000", Offset = "0x7ED7400", VA = "0x187ED8000")]
	public static MMAIIDJOPMJ IMNGEJKLHKO(IBEKEEPBPDF GIDGOODJFLJ, IFIJOBDPIGK GEBLLCFNKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8450", Offset = "0x7ED7850", VA = "0x187ED8450")]
	private MMAIIDJOPMJ(IBEKEEPBPDF GIDGOODJFLJ, IFIJOBDPIGK GEBLLCFNKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7B70", Offset = "0x7ED6F70", VA = "0x187ED7B70")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8180", Offset = "0x7ED7580", VA = "0x187ED8180")]
	[IteratorStateMachine(typeof(NMHBLPBNKPK))]
	public IEnumerable<Renderer> KNPLMAJOPFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED70B0", Offset = "0x7ED64B0", VA = "0x187ED70B0", Slot = "4")]
	public void EOLAGDPNCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8150", Offset = "0x7ED7550", VA = "0x187ED8150")]
	private void KNNCAHANIFH(Vector3 HLLEBBDLEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8200", Offset = "0x7ED7600", VA = "0x187ED8200")]
	public void PLJNMJIHBJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MMJDOJKFJKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct KJBBBICGMEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AIIDIKHPDOL EBMHKBDPKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public LCHJICBNMPB JFAIBOCEKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int BJPCANOALJK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BIAPGFHHNPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public MMJDOJKFJKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NNLGOHCCLAH lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<KJBBBICGMEE> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FBFDINCPKFI combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BIAPGFHHNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF9B0", Offset = "0x7ECEDB0", VA = "0x187ECF9B0")]
		internal JobHandle MMFIKBIHOOK()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF810", Offset = "0x7ECEC10", VA = "0x187ECF810")]
		internal void BIBMCJOGPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7ECF840", Offset = "0x7ECEC40", VA = "0x187ECF840")]
		internal void KCOKGPMKFAM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] MKBEILKPCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private IMAJDBCGAGL CHGJKGOBAIE;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 JJFJFMIKNFN;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh HBCKFNLBLKI
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DHJENKIBIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x94D450", Offset = "0x94C850", VA = "0x18094D450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8530", Offset = "0x7ED7930", VA = "0x187ED8530")]
	public void AGDDKAFDJPG(List<LCHJICBNMPB> GCPJMGJCECJ, Matrix4x4[] HJJMGGJFOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8C10", Offset = "0x7ED8010", VA = "0x187ED8C10")]
	public static List<MMJDOJKFJKC> OILMBKHFGKP(List<EGHKOOBHNBK> KOIGMCDHLCI, NNLGOHCCLAH GNAJNFCKONF, Bounds LMEMOMNCOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8720", Offset = "0x7ED7B20", VA = "0x187ED8720")]
	private JobHandle BCDGPAGELDH(FBFDINCPKFI LNPCMKINCOJ, int NCNLMCPMFCK, int LMFBKOOOEDD, NNLGOHCCLAH GNAJNFCKONF, List<KJBBBICGMEE> DIKEBHEODME)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8A90", Offset = "0x7ED7E90", VA = "0x187ED8A90")]
	private void CNKKOLGGJBH(List<KJBBBICGMEE> DIKEBHEODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9440", Offset = "0x7ED8840", VA = "0x187ED9440")]
	private MMJDOJKFJKC(List<KJBBBICGMEE> DIKEBHEODME, int NCNLMCPMFCK, int LMFBKOOOEDD, NNLGOHCCLAH GNAJNFCKONF, Bounds LMEMOMNCOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8B70", Offset = "0x7ED7F70", VA = "0x187ED8B70", Slot = "4")]
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
		private MaterialPropertyBlock BBIJHOEALAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private MMJDOJKFJKC LCGHOEMEOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<LCHJICBNMPB> BLNGGKCOHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture BDCGOJGLBEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer NEKPDLHGODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader FPJAFNNDMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] MFNGGGFIGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int IOFMGFOHLJG;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer JECIIKIIBIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int EMEJHMBPJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7EE2980", Offset = "0x7EE1D80", VA = "0x187EE2980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2020", Offset = "0x7EE1420", VA = "0x187EE2020")]
		public static List<SkinnedShapeRenderer> Create(GameObject JGHOOBNHEJB, List<MMJDOJKFJKC> MEDHCPCLFFL, List<LCHJICBNMPB> BLNGGKCOHMF, Material HJCEHLILOIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2370", Offset = "0x7EE1770", VA = "0x187EE2370")]
		public void Init(MMJDOJKFJKC LCGHOEMEOEK, List<LCHJICBNMPB> BLNGGKCOHMF, Material HJCEHLILOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE28E0", Offset = "0x7EE1CE0", VA = "0x187EE28E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2840", Offset = "0x7EE1C40", VA = "0x187EE2840")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2800", Offset = "0x7EE1C00", VA = "0x187EE2800")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7EE22B0", Offset = "0x7EE16B0", VA = "0x187EE22B0")]
		private void EHNKCJGJNAD(ScriptableRenderContext BPPCEJGCMKA, Camera[] CFPPKCDILEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1CB0", Offset = "0x7EE10B0", VA = "0x187EE1CB0")]
		private void AGDDKAFDJPG(CommandBuffer PCFAPMNCMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
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
