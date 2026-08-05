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
		[Cpp2IlInjected.Address(RVA = "0x7F7B9C0", Offset = "0x7F79FC0", VA = "0x187F7B9C0", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F87AE0", Offset = "0x7F860E0", VA = "0x187F87AE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB44CD0", Offset = "0xB432D0", VA = "0x180B44CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MBNLDPKNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x991F60", Offset = "0x990560", VA = "0x180991F60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9915B0", Offset = "0x98FBB0", VA = "0x1809915B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float NNOLELLJELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD7A6F0", Offset = "0xD78CF0", VA = "0x180D7A6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1036AF0", Offset = "0x10350F0", VA = "0x181036AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CJEAMCILIHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAED5D0", Offset = "0xAEBBD0", VA = "0x180AED5D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAED5E0", Offset = "0xAEBBE0", VA = "0x180AED5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> CIEPCJONGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F85D30", Offset = "0x7F84330", VA = "0x187F85D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> HAEJNKBAOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F861C0", Offset = "0x7F847C0", VA = "0x187F861C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x954470", Offset = "0x952A70", VA = "0x180954470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte JJPCCOLOEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F85EC0", Offset = "0x7F844C0", VA = "0x187F85EC0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F86310", Offset = "0x7F84910", VA = "0x187F86310")]
	public POIKINCNHOI(List<MMJDOJKFJKC> MIGOIDBBCPH, List<MMJDOJKFJKC> FKIEHALJENE, List<LCHJICBNMPB> BLNGGKCOHMF, Material HJCEHLILOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F861F0", Offset = "0x7F847F0", VA = "0x187F861F0")]
	private int OOONHBLCKPL(List<MMJDOJKFJKC> MEDHCPCLFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F85F10", Offset = "0x7F84510", VA = "0x187F85F10")]
	private void ILIOKNKCCKI(int CNAOCCEHOGI, bool IMLBMCFLIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F86070", Offset = "0x7F84670", VA = "0x187F86070")]
	public void KOJBMAHGHGD(Vector3 HLLEBBDLEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F85D80", Offset = "0x7F84380", VA = "0x187F85D80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F85E80", Offset = "0x7F84480", VA = "0x187F85E80")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public OHIBKMNOLGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7F83270", Offset = "0x7F81870", VA = "0x187F83270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F82C60", Offset = "0x7F81260", VA = "0x187F82C60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F82B70", Offset = "0x7F81170", VA = "0x187F82B70")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F82BC0", Offset = "0x7F811C0", VA = "0x187F82BC0")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F82C10", Offset = "0x7F81210", VA = "0x187F82C10")]
		private void FCJODFEMCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F83220", Offset = "0x7F81820", VA = "0x187F83220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F83170", Offset = "0x7F81770", VA = "0x187F83170", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F83170", Offset = "0x7F81770", VA = "0x187F83170", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public LGIPLFIMGHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B690", Offset = "0x7F79C90", VA = "0x187F7B690", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B220", Offset = "0x7F79820", VA = "0x187F7B220", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B180", Offset = "0x7F79780", VA = "0x187F7B180")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B1D0", Offset = "0x7F797D0", VA = "0x187F7B1D0")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B640", Offset = "0x7F79C40", VA = "0x187F7B640", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B590", Offset = "0x7F79B90", VA = "0x187F7B590", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B590", Offset = "0x7F79B90", VA = "0x187F7B590", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JDMNHHPGBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F75AD0", Offset = "0x7F740D0", VA = "0x187F75AD0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LCHJICBNMPB MEJHMILJPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F75830", Offset = "0x7F73E30", VA = "0x187F75830", Slot = "8")]
		get
		{
			return default(LCHJICBNMPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> MIJKPLFPKPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x956AD0", Offset = "0x9550D0", VA = "0x180956AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F75B90", Offset = "0x7F74190", VA = "0x187F75B90")]
	private bool MMADCLHHCFJ(LIGBIBGKMNI LFCFKCMCBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F74A20", Offset = "0x7F73020", VA = "0x187F74A20")]
	private static bool BMMDOMLIOEA(LIGBIBGKMNI LFCFKCMCBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F76340", Offset = "0x7F74940", VA = "0x187F76340")]
	public EGHKOOBHNBK(LIJGIKFJLHJ GIDGOODJFLJ, bool OMPOIHMLEAJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F75140", Offset = "0x7F73740", VA = "0x187F75140", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F75900", Offset = "0x7F73F00", VA = "0x187F75900")]
	public void HBHDBABAKDP(LIGBIBGKMNI LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F75C80", Offset = "0x7F74280", VA = "0x187F75C80")]
	public void OCDDHDAHAOD(LIGBIBGKMNI LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F75330", Offset = "0x7F73930", VA = "0x187F75330", Slot = "4")]
	public void EOLAGDPNCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F76050", Offset = "0x7F74650", VA = "0x187F76050")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F75DE0", Offset = "0x7F743E0", VA = "0x187F75DE0")]
	private void OHCHFMGBJFN(List<LIGBIBGKMNI> NOPAPHLJJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F747E0", Offset = "0x7F72DE0", VA = "0x187F747E0")]
	private static Material HONNMHOECBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F75FA0", Offset = "0x7F745A0", VA = "0x187F75FA0")]
	private void OHCHFMGBJFN(LIGBIBGKMNI LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F75BB0", Offset = "0x7F741B0", VA = "0x187F75BB0")]
	private void MMNKHADNKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F74AC0", Offset = "0x7F730C0", VA = "0x187F74AC0")]
	public void DGHHHCJHPFL(bool PHNDGJMLNBL, bool JJDBODNKGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F75080", Offset = "0x7F73680", VA = "0x187F75080")]
	protected void DONKCMHBEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F74A40", Offset = "0x7F73040", VA = "0x187F74A40")]
	public void CLHMHAAGGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F75B10", Offset = "0x7F74110", VA = "0x187F75B10")]
	[IteratorStateMachine(typeof(OHIBKMNOLGM))]
	public IEnumerable<Renderer> KNPLMAJOPFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F762C0", Offset = "0x7F748C0", VA = "0x187F762C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F73BB0", Offset = "0x7F721B0", VA = "0x187F73BB0")]
		public AHGEFBIIDML(FBFDINCPKFI LCGHOEMEOEK, JobHandle NIJHHKONNDH, CDMFKIAEDKP OFNDGACAHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7F73B80", Offset = "0x7F72180", VA = "0x187F73B80", Slot = "4")]
		public FBFDINCPKFI HMABCBLNCNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7F73B30", Offset = "0x7F72130", VA = "0x187F73B30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F844D0", Offset = "0x7F82AD0", VA = "0x187F844D0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F84DC0", Offset = "0x7F833C0", VA = "0x187F84DC0")]
	public OKLDIBJBHKM(EGHKOOBHNBK JGHOOBNHEJB, MIIIGIALJDC GIDGOODJFLJ, bool OMPOIHMLEAJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "18")]
	public override bool MKNJJOFADEL(LCHJICBNMPB JGHOOBNHEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F84BF0", Offset = "0x7F831F0", VA = "0x187F84BF0", Slot = "19")]
	public override int OOONHBLCKPL(NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F84300", Offset = "0x7F82900", VA = "0x187F84300", Slot = "20")]
	public override int IMAMFLJKHIL(NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F83EC0", Offset = "0x7F824C0", VA = "0x187F83EC0", Slot = "21")]
	public override DJOEGFIEAIG IICEDMGKFFF()
	{
		return default(DJOEGFIEAIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xAB2220", Offset = "0xAB0820", VA = "0x180AB2220", Slot = "22")]
	public override float LLOMFPLMHGG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F84600", Offset = "0x7F82C00", VA = "0x187F84600", Slot = "23")]
	public override void OOEKFELFHKF(NNLGOHCCLAH GNAJNFCKONF, AIIDIKHPDOL EALLMICPGEN, int NILELNIMHMO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F83DF0", Offset = "0x7F823F0", VA = "0x187F83DF0", Slot = "24")]
	public override LCHJICBNMPB HCAOBHMHALE()
	{
		return default(LCHJICBNMPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F83460", Offset = "0x7F81A60", VA = "0x187F83460", Slot = "26")]
	public override JCMJGMDLFJF DOJPJOCGEBJ()
	{
		return default(JCMJGMDLFJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F83620", Offset = "0x7F81C20", VA = "0x187F83620", Slot = "27")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F73C10", Offset = "0x7F72210", VA = "0x187F73C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7F74190", Offset = "0x7F72790", VA = "0x187F74190", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F779D0", Offset = "0x7F75FD0", VA = "0x187F779D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public LIGBIBGKMNI NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7F77970", Offset = "0x7F75F70", VA = "0x187F77970", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MMAIIDJOPMJ NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F77910", Offset = "0x7F75F10", VA = "0x187F77910", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool HLNLNNLFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9C3E0", VA = "0x180C9DDE0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC9DCD0", Offset = "0xC9C2D0", VA = "0x180C9DCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F78650", Offset = "0x7F76C50", VA = "0x187F78650")]
	public HDMBGLIIDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F76DF0", Offset = "0x7F753F0", VA = "0x187F76DF0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F77CB0", Offset = "0x7F762B0", VA = "0x187F77CB0", Slot = "4")]
	public DGKNAAFCKEM LECFEEGHGFO(LIJGIKFJLHJ GIDGOODJFLJ)
	{
		return default(DGKNAAFCKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F77A30", Offset = "0x7F76030", VA = "0x187F77A30", Slot = "5")]
	public DGKNAAFCKEM LECFEEGHGFO(LIJGIKFJLHJ GIDGOODJFLJ, bool OMPOIHMLEAJ)
	{
		return default(DGKNAAFCKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F76430", Offset = "0x7F74A30", VA = "0x187F76430", Slot = "6")]
	public void AEFEIDCAEMJ(DGKNAAFCKEM JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F766F0", Offset = "0x7F74CF0", VA = "0x187F766F0", Slot = "7")]
	public void BECJIHFLKFF(DGKNAAFCKEM JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F77430", Offset = "0x7F75A30", VA = "0x187F77430", Slot = "8")]
	public EEGJHJCMEBL IDGPMNHFJPC(DGKNAAFCKEM JGHOOBNHEJB, GGPLGOGDNFL GIDGOODJFLJ)
	{
		return default(EEGJHJCMEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F77D40", Offset = "0x7F76340", VA = "0x187F77D40", Slot = "9")]
	public EEGJHJCMEBL MHIODBIACKH(DGKNAAFCKEM JGHOOBNHEJB, MIIIGIALJDC GIDGOODJFLJ)
	{
		return default(EEGJHJCMEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7F78220", Offset = "0x7F76820", VA = "0x187F78220", Slot = "11")]
	public void NHEDDCGKKDL(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F76B90", Offset = "0x7F75190", VA = "0x187F76B90", Slot = "10")]
	public void DPFAHEDNFKP(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F785E0", Offset = "0x7F76BE0", VA = "0x187F785E0", Slot = "20")]
	public IEnumerable<Renderer> PEEAEAFPGBE(DGKNAAFCKEM JGHOOBNHEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F77CC0", Offset = "0x7F762C0", VA = "0x187F77CC0", Slot = "12")]
	public MDKOADIDEPC MFNIMEIGABP(IBEKEEPBPDF GIDGOODJFLJ)
	{
		return default(MDKOADIDEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F76B20", Offset = "0x7F75120", VA = "0x187F76B20", Slot = "14")]
	public void BNIFBBPPMNC(MDKOADIDEPC OEJFCMJKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F770B0", Offset = "0x7F756B0", VA = "0x187F770B0", Slot = "16")]
	public Task ECNFKAOMLMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7F77270", Offset = "0x7F75870", VA = "0x187F77270", Slot = "17")]
	public Task FKBAAGJCFKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F76A50", Offset = "0x7F75050", VA = "0x187F76A50", Slot = "18")]
	[AsyncStateMachine(typeof(BBKIMKHKLAK))]
	public Task BIJDBGPKDAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F76FC0", Offset = "0x7F755C0", VA = "0x187F76FC0", Slot = "19")]
	public void ECMDOCJBIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7F76690", Offset = "0x7F74C90", VA = "0x187F76690", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F744F0", Offset = "0x7F72AF0", VA = "0x187F744F0")]
		public CMCILIMAACP(FBFDINCPKFI LCGHOEMEOEK, NativeArray<int> JOLIFHDDFMM, JobHandle NIJHHKONNDH, GFIHIHGEMHO OFNDGACAHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7F74490", Offset = "0x7F72A90", VA = "0x187F74490", Slot = "4")]
		public FBFDINCPKFI HMABCBLNCNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7F743F0", Offset = "0x7F729F0", VA = "0x187F743F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F799E0", Offset = "0x7F77FE0", VA = "0x187F799E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 BADNBOCGGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A310", Offset = "0x7F78910", VA = "0x187F7A310", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F7AF10", Offset = "0x7F79510", VA = "0x187F7AF10")]
	public KCKDPHBANLP(EGHKOOBHNBK JGHOOBNHEJB, GGPLGOGDNFL GIDGOODJFLJ, bool IKBPPKMOIMF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F7A530", Offset = "0x7F78B30", VA = "0x187F7A530", Slot = "18")]
	public override bool MKNJJOFADEL(LCHJICBNMPB JGHOOBNHEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F7A220", Offset = "0x7F78820", VA = "0x187F7A220", Slot = "21")]
	public override DJOEGFIEAIG IICEDMGKFFF()
	{
		return default(DJOEGFIEAIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F79C10", Offset = "0x7F78210", VA = "0x187F79C10")]
	private DJOEGFIEAIG IICEDMGKFFF(LCHJICBNMPB JGHOOBNHEJB)
	{
		return default(DJOEGFIEAIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F78B00", Offset = "0x7F77100", VA = "0x187F78B00")]
	private MKCHKHONKEK AMADBEIAKKI([In] UniformTRS GOPPDMAABGE, [In] float3 IGOKMENAGDH)
	{
		return default(MKCHKHONKEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F7AE60", Offset = "0x7F79460", VA = "0x187F7AE60", Slot = "19")]
	public override int OOONHBLCKPL(NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F7A260", Offset = "0x7F78860", VA = "0x187F7A260", Slot = "20")]
	public override int IMAMFLJKHIL(NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F7A440", Offset = "0x7F78A40", VA = "0x187F7A440", Slot = "22")]
	public override float LLOMFPLMHGG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7F79690", Offset = "0x7F77C90", VA = "0x187F79690")]
	private int GOKPDDADBAE(NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F7A600", Offset = "0x7F78C00", VA = "0x187F7A600", Slot = "23")]
	public override void OOEKFELFHKF(NNLGOHCCLAH GNAJNFCKONF, AIIDIKHPDOL EALLMICPGEN, int NILELNIMHMO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F79910", Offset = "0x7F77F10", VA = "0x187F79910", Slot = "24")]
	public override LCHJICBNMPB HCAOBHMHALE()
	{
		return default(LCHJICBNMPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7F78D00", Offset = "0x7F77300", VA = "0x187F78D00", Slot = "26")]
	public override JCMJGMDLFJF DOJPJOCGEBJ()
	{
		return default(JCMJGMDLFJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7F78EC0", Offset = "0x7F774C0", VA = "0x187F78EC0", Slot = "27")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F749D0", Offset = "0x7F72FD0", VA = "0x187F749D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x95ED80", Offset = "0x95D380", VA = "0x18095ED80")]
	public MNMFLBHOHEB(ACMNLEILIEG EELACOIEKHA, IFIJOBDPIGK GEBLLCFNKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F7ECD0", Offset = "0x7F7D2D0", VA = "0x187F7ECD0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F7EE80", Offset = "0x7F7D480", VA = "0x187F7EE80")]
	private void ELIJOHCEKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E650", Offset = "0x7F7CC50", VA = "0x187F7E650", Slot = "4")]
	public void CGFBAPGPBML(DGKNAAFCKEM JGHOOBNHEJB, FFCHMNNCDPE BANIDBBGDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E960", Offset = "0x7F7CF60", VA = "0x187F7E960", Slot = "5")]
	public void CGFBAPGPBML(EEGJHJCMEBL LFCFKCMCBCB, FFCHMNNCDPE BANIDBBGDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F7FDD0", Offset = "0x7F7E3D0", VA = "0x187F7FDD0", Slot = "6")]
	public void NDOKGNLMCFH(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F7EB80", Offset = "0x7F7D180", VA = "0x187F7EB80", Slot = "7")]
	public void DDHOPDHDIKK(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7F7FF30", Offset = "0x7F7E530", VA = "0x187F7FF30", Slot = "24")]
	public void OCBGOHOEKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xED4FA0", Offset = "0xED35A0", VA = "0x180ED4FA0", Slot = "8")]
	public void INMGJNLANCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F500", Offset = "0x7F7DB00", VA = "0x187F7F500", Slot = "9")]
	public void IMDJAAPNKBM(FFCHMNNCDPE BANIDBBGDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F670", Offset = "0x7F7DC70", VA = "0x187F7F670", Slot = "10")]
	public void LMAIBOOHJBD(DGKNAAFCKEM JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F940", Offset = "0x7F7DF40", VA = "0x187F7F940", Slot = "11")]
	public void LMAIBOOHJBD(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E580", Offset = "0x7F7CB80", VA = "0x187F7E580", Slot = "12")]
	public void CDECFIAEKHN(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F0F0", Offset = "0x7F7D6F0", VA = "0x187F7F0F0", Slot = "13")]
	public void FJPCKAONCBJ(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F290", Offset = "0x7F7D890", VA = "0x187F7F290")]
	private void HDECMPCPDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x11355A0", Offset = "0x1133BA0", VA = "0x1811355A0", Slot = "14")]
	public void FIJKHFOPMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F80250", Offset = "0x7F7E850", VA = "0x187F80250", Slot = "15")]
	public void OPBGNHAIBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F7FF70", Offset = "0x7F7E570", VA = "0x187F7FF70", Slot = "16")]
	public void OGNANCMJPAP(DGKNAAFCKEM JGHOOBNHEJB, MDOKODFBGBL BMIPLDLMPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E240", Offset = "0x7F7C840", VA = "0x187F7E240", Slot = "17")]
	public void AAJGNBPGGLE(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F1C0", Offset = "0x7F7D7C0", VA = "0x187F7F1C0", Slot = "18")]
	public void FOHCAFGBAOM(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xB4B790", Offset = "0xB49D90", VA = "0x180B4B790", Slot = "19")]
	public void IGFDEMDADNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F7FCA0", Offset = "0x7F7E2A0", VA = "0x187F7FCA0", Slot = "20")]
	public void MKNLHEEPNAI(MDOKODFBGBL BMIPLDLMPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E310", Offset = "0x7F7C910", VA = "0x187F7E310")]
	private void AFPPMHGGOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F80810", Offset = "0x7F7EE10", VA = "0x187F80810", Slot = "21")]
	public void OPCOFKAIJBF(DGKNAAFCKEM JGHOOBNHEJB, Vector3 NCMGFAIKAJI, Vector3 IMLCMDAJDCN, Vector3 GIBOOHLHGPF, float NMNOINHHBAP, float KNKFMCLLNFN, IReadOnlyList<Camera> MFLLGDBFINI, JKMBBDPLCIH OEIGHBFCMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F80370", Offset = "0x7F7E970", VA = "0x187F80370", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F7B9A0", Offset = "0x7F79FA0", VA = "0x187F7B9A0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool IIDBNBEANPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC0ECF0", Offset = "0xC0D2F0", VA = "0x180C0ECF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC0EE00", Offset = "0xC0D400", VA = "0x180C0EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA743C0", Offset = "0xA729C0", VA = "0x180A743C0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public AEOFEDMEIPE LCKICDFPPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x956AD0", Offset = "0x9550D0", VA = "0x180956AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool KLIBABDMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xD36510", Offset = "0xD34B10", VA = "0x180D36510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	protected LIGBIBGKMNI(EGHKOOBHNBK JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B800", Offset = "0x7F79E00", VA = "0x187F7B800", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "18")]
	public virtual bool MKNJJOFADEL(LCHJICBNMPB JGHOOBNHEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F7B7C0", Offset = "0x7F79DC0", VA = "0x187F7B7C0", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7F7B970", Offset = "0x7F79F70", VA = "0x187F7B970", Slot = "13")]
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
	[Cpp2IlInjected.Address(RVA = "0x7F7B7D0", Offset = "0x7F79DD0", VA = "0x187F7B7D0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F86630", Offset = "0x7F84C30", VA = "0x187F86630")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public LBEJGAKJDEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AFC0", Offset = "0x7F795C0", VA = "0x187F7AFC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B130", Offset = "0x7F79730", VA = "0x187F7B130", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B090", Offset = "0x7F79690", VA = "0x187F7B090", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BFKPFEOEFPC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B090", Offset = "0x7F79690", VA = "0x187F7B090", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F81040", Offset = "0x7F7F640", VA = "0x187F81040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer KFDMAADKCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F80FE0", Offset = "0x7F7F5E0", VA = "0x187F80FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F81650", Offset = "0x7F7FC50", VA = "0x187F81650")]
	[ONDAMKAMKDB]
	internal static void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F81900", Offset = "0x7F7FF00", VA = "0x187F81900")]
	public static Mesh MAEIKHELAAN(OMANHOCOLNE EABCDIJJBLA, int GNAJNFCKONF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F818F0", Offset = "0x7F7FEF0", VA = "0x187F818F0")]
	public static int LIPOJJAOPAD(OMANHOCOLNE EABCDIJJBLA, int GNAJNFCKONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F819D0", Offset = "0x7F7FFD0", VA = "0x187F819D0")]
	public static LHIMPKGNCEC NDAIOMKKFEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7F82A10", Offset = "0x7F81010", VA = "0x187F82A10")]
	[IteratorStateMachine(typeof(LBEJGAKJDEG))]
	private static IEnumerable<BFKPFEOEFPC> OMFJGLEDLFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F81BF0", Offset = "0x7F801F0", VA = "0x187F81BF0")]
	public static BFKPFEOEFPC NKEBIDOLAGJ(OMANHOCOLNE EABCDIJJBLA, int GNAJNFCKONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F819A0", Offset = "0x7F7FFA0", VA = "0x187F819A0")]
	public static bool MJCKIBCEGEI(this OMANHOCOLNE EABCDIJJBLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F81740", Offset = "0x7F7FD40", VA = "0x187F81740")]
	public static void KJONAJDJOAC(OMANHOCOLNE EABCDIJJBLA, float3 IEBDAOEEHDK, [Out] EKABDFAIFNM BDMOAALHBKO, [Out] float3 PMMPGHCFKMA, [Out] float CJDKGDBGDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7F810A0", Offset = "0x7F7F6A0", VA = "0x187F810A0")]
	public static void DPBMOLBDJOG(Vector3 IEBDAOEEHDK, OMANHOCOLNE EABCDIJJBLA, [Out] Vector3 PMMPGHCFKMA, [Out] float CJDKGDBGDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F819C0", Offset = "0x7F7FFC0", VA = "0x187F819C0")]
	[FBDKNMPMDID(0)]
	[JBPLEELDMPC(GALPNODIPPP.ExitingPlayMode, 0)]
	private static void MKEDLLGPABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F81470", Offset = "0x7F7FA70", VA = "0x187F81470")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F85430", Offset = "0x7F83A30", VA = "0x187F85430", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public LIGBIBGKMNI NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F854F0", Offset = "0x7F83AF0", VA = "0x187F854F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public MMAIIDJOPMJ NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F85490", Offset = "0x7F83A90", VA = "0x187F85490", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HLNLNNLFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9C3E0", VA = "0x180C9DDE0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC9DCD0", Offset = "0xC9C2D0", VA = "0x180C9DCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F85940", Offset = "0x7F83F40", VA = "0x187F85940")]
	public PGBFEJMGNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F85120", Offset = "0x7F83720", VA = "0x187F85120", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F85550", Offset = "0x7F83B50", VA = "0x187F85550", Slot = "4")]
	public DGKNAAFCKEM LECFEEGHGFO(LIJGIKFJLHJ GIDGOODJFLJ)
	{
		return default(DGKNAAFCKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F85550", Offset = "0x7F83B50", VA = "0x187F85550", Slot = "5")]
	public DGKNAAFCKEM LECFEEGHGFO(LIJGIKFJLHJ GIDGOODJFLJ, bool OMPOIHMLEAJ)
	{
		return default(DGKNAAFCKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F84E70", Offset = "0x7F83470", VA = "0x187F84E70", Slot = "6")]
	public void AEFEIDCAEMJ(DGKNAAFCKEM JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F84F30", Offset = "0x7F83530", VA = "0x187F84F30", Slot = "7")]
	public void BECJIHFLKFF(DGKNAAFCKEM JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F852F0", Offset = "0x7F838F0", VA = "0x187F852F0", Slot = "8")]
	public EEGJHJCMEBL IDGPMNHFJPC(DGKNAAFCKEM JGHOOBNHEJB, GGPLGOGDNFL GIDGOODJFLJ)
	{
		return default(EEGJHJCMEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F85670", Offset = "0x7F83C70", VA = "0x187F85670", Slot = "9")]
	public EEGJHJCMEBL MHIODBIACKH(DGKNAAFCKEM JGHOOBNHEJB, MIIIGIALJDC GIDGOODJFLJ)
	{
		return default(EEGJHJCMEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F857B0", Offset = "0x7F83DB0", VA = "0x187F857B0", Slot = "11")]
	public void NHEDDCGKKDL(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7F850C0", Offset = "0x7F836C0", VA = "0x187F850C0", Slot = "10")]
	public void DPFAHEDNFKP(EEGJHJCMEBL LFCFKCMCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7F85840", Offset = "0x7F83E40", VA = "0x187F85840", Slot = "20")]
	public IEnumerable<Renderer> PEEAEAFPGBE(DGKNAAFCKEM JGHOOBNHEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F855F0", Offset = "0x7F83BF0", VA = "0x187F855F0", Slot = "12")]
	public MDKOADIDEPC MFNIMEIGABP(IBEKEEPBPDF GIDGOODJFLJ)
	{
		return default(MDKOADIDEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7F85050", Offset = "0x7F83650", VA = "0x187F85050", Slot = "14")]
	public void BNIFBBPPMNC(MDKOADIDEPC OEJFCMJKFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F851B0", Offset = "0x7F837B0", VA = "0x187F851B0", Slot = "16")]
	public Task ECNFKAOMLMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F85250", Offset = "0x7F83850", VA = "0x187F85250", Slot = "17")]
	public Task FKBAAGJCFKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F84FB0", Offset = "0x7F835B0", VA = "0x187F84FB0", Slot = "18")]
	public Task BIJDBGPKDAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x248BFB0", Offset = "0x248A5B0", VA = "0x18248BFB0", Slot = "19")]
	public void ECMDOCJBIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F84ED0", Offset = "0x7F834D0", VA = "0x187F84ED0", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F74550", Offset = "0x7F72B50", VA = "0x187F74550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7F748A0", Offset = "0x7F72EA0", VA = "0x187F748A0")]
	public static void LEFOFLNEOOO(CEEKKJJLJDG PKBEMFNNIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7F74840", Offset = "0x7F72E40", VA = "0x187F74840")]
	public static Material KKKNGJEHJPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7F747E0", Offset = "0x7F72DE0", VA = "0x187F747E0")]
	public static Material HONNMHOECBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7F74970", Offset = "0x7F72F70", VA = "0x187F74970")]
	public static Material NHIHBBGKNFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7F74900", Offset = "0x7F72F00", VA = "0x187F74900")]
	public static int MNFCBCDHMFA(MONBNMPFMMO FEIBMFKLDKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7F745B0", Offset = "0x7F72BB0", VA = "0x187F745B0")]
	public static int DABEJAOLCDF(CEHJAJCAOIA KANJCAGIGJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7F74710", Offset = "0x7F72D10", VA = "0x187F74710")]
	public static void HJOLBKHGEPK(GameObject GMFKPONAANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7F74620", Offset = "0x7F72C20", VA = "0x187F74620")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public NMHBLPBNKPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7F80F50", Offset = "0x7F7F550", VA = "0x187F80F50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7F80C30", Offset = "0x7F7F230", VA = "0x187F80C30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7F80BE0", Offset = "0x7F7F1E0", VA = "0x187F80BE0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7F80F00", Offset = "0x7F7F500", VA = "0x187F80F00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7F80E50", Offset = "0x7F7F450", VA = "0x187F80E50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7F80E50", Offset = "0x7F7F450", VA = "0x187F80E50", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7F7C9E0", Offset = "0x7F7AFE0", VA = "0x187F7C9E0")]
	public static MMAIIDJOPMJ IMNGEJKLHKO(IBEKEEPBPDF GIDGOODJFLJ, IFIJOBDPIGK GEBLLCFNKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7F7CE30", Offset = "0x7F7B430", VA = "0x187F7CE30")]
	private MMAIIDJOPMJ(IBEKEEPBPDF GIDGOODJFLJ, IFIJOBDPIGK GEBLLCFNKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7F7C550", Offset = "0x7F7AB50", VA = "0x187F7C550")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7F7CB60", Offset = "0x7F7B160", VA = "0x187F7CB60")]
	[IteratorStateMachine(typeof(NMHBLPBNKPK))]
	public IEnumerable<Renderer> KNPLMAJOPFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BA90", Offset = "0x7F7A090", VA = "0x187F7BA90", Slot = "4")]
	public void EOLAGDPNCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7F7CB30", Offset = "0x7F7B130", VA = "0x187F7CB30")]
	private void KNNCAHANIFH(Vector3 HLLEBBDLEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7F7CBE0", Offset = "0x7F7B1E0", VA = "0x187F7CBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BIAPGFHHNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7F74390", Offset = "0x7F72990", VA = "0x187F74390")]
		internal JobHandle MMFIKBIHOOK()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7F741F0", Offset = "0x7F727F0", VA = "0x187F741F0")]
		internal void BIBMCJOGPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7F74220", Offset = "0x7F72820", VA = "0x187F74220")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DHJENKIBIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952A80", VA = "0x180954480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x954450", Offset = "0x952A50", VA = "0x180954450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7F7CF10", Offset = "0x7F7B510", VA = "0x187F7CF10")]
	public void AGDDKAFDJPG(List<LCHJICBNMPB> GCPJMGJCECJ, Matrix4x4[] HJJMGGJFOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7F7D5F0", Offset = "0x7F7BBF0", VA = "0x187F7D5F0")]
	public static List<MMJDOJKFJKC> OILMBKHFGKP(List<EGHKOOBHNBK> KOIGMCDHLCI, NNLGOHCCLAH GNAJNFCKONF, Bounds LMEMOMNCOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7F7D100", Offset = "0x7F7B700", VA = "0x187F7D100")]
	private JobHandle BCDGPAGELDH(FBFDINCPKFI LNPCMKINCOJ, int NCNLMCPMFCK, int LMFBKOOOEDD, NNLGOHCCLAH GNAJNFCKONF, List<KJBBBICGMEE> DIKEBHEODME)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7F7D470", Offset = "0x7F7BA70", VA = "0x187F7D470")]
	private void CNKKOLGGJBH(List<KJBBBICGMEE> DIKEBHEODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7F7DE20", Offset = "0x7F7C420", VA = "0x187F7DE20")]
	private MMJDOJKFJKC(List<KJBBBICGMEE> DIKEBHEODME, int NCNLMCPMFCK, int LMFBKOOOEDD, NNLGOHCCLAH GNAJNFCKONF, Bounds LMEMOMNCOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7F7D550", Offset = "0x7F7BB50", VA = "0x187F7D550", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int EMEJHMBPJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7F87360", Offset = "0x7F85960", VA = "0x187F87360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7F86A00", Offset = "0x7F85000", VA = "0x187F86A00")]
		public static List<SkinnedShapeRenderer> Create(GameObject JGHOOBNHEJB, List<MMJDOJKFJKC> MEDHCPCLFFL, List<LCHJICBNMPB> BLNGGKCOHMF, Material HJCEHLILOIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7F86D50", Offset = "0x7F85350", VA = "0x187F86D50")]
		public void Init(MMJDOJKFJKC LCGHOEMEOEK, List<LCHJICBNMPB> BLNGGKCOHMF, Material HJCEHLILOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7F872C0", Offset = "0x7F858C0", VA = "0x187F872C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7F87220", Offset = "0x7F85820", VA = "0x187F87220")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7F871E0", Offset = "0x7F857E0", VA = "0x187F871E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7F86C90", Offset = "0x7F85290", VA = "0x187F86C90")]
		private void EHNKCJGJNAD(ScriptableRenderContext BPPCEJGCMKA, Camera[] CFPPKCDILEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7F86690", Offset = "0x7F84C90", VA = "0x187F86690")]
		private void AGDDKAFDJPG(CommandBuffer PCFAPMNCMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
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
