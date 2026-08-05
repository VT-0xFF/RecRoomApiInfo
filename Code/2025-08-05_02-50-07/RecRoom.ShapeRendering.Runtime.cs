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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8E2CA40", Offset = "0x8E2BE40", VA = "0x188E2CA40", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E32B60", Offset = "0x8E31F60", VA = "0x188E32B60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LKFDBNECOFA : IOKJJACLCJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte ANHKEFNPCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] GJNFENFOHGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CDHOHDLKMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JDIDCOLFMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7F0", Offset = "0xC19BF0", VA = "0x180C1A7F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x104AEA0", Offset = "0x104A2A0", VA = "0x18104AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float BINNDNBPCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1057300", Offset = "0x1056700", VA = "0x181057300", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1561E90", Offset = "0x1561290", VA = "0x181561E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DAFHHCOKGMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD61A50", Offset = "0xD60E50", VA = "0x180D61A50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD61A60", Offset = "0xD60E60", VA = "0x180D61A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> FOKJLDMLCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8E2C240", Offset = "0x8E2B640", VA = "0x188E2C240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> LKPEJHGNLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8E2C440", Offset = "0x8E2B840", VA = "0x188E2C440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte PJNGKADPOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E2C290", Offset = "0x8E2B690", VA = "0x188E2C290", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8E2C720", Offset = "0x8E2BB20", VA = "0x188E2C720")]
	public LKFDBNECOFA(List<CLNOEEGCPGP> DAOFDFPLACK, List<CLNOEEGCPGP> KONJFGIABLE, List<GIJLHKFOFFB> CAHEAFKKKBK, Material GMFBEMFEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8E2C4B0", Offset = "0x8E2B8B0", VA = "0x188E2C4B0")]
	private int JIKCBGILJOG(List<CLNOEEGCPGP> LCOEDLEMBLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8E2C2E0", Offset = "0x8E2B6E0", VA = "0x188E2C2E0")]
	private void FPBBKNLJFJG(int FPDFKLGFDPO, bool BAMGENIDGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8E2C5D0", Offset = "0x8E2B9D0", VA = "0x188E2C5D0")]
	public void KMLAKKMBFKC(Vector3 ALEAEKJGEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8E2C140", Offset = "0x8E2B540", VA = "0x188E2C140", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8E2C470", Offset = "0x8E2B870", VA = "0x188E2C470")]
	public void IPPOOOMAKLA(Transform LFCAFNDDAON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DFBCAKHBLPJ : PHAPANCEJFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class NKCLOIOHHAA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DFBCAKHBLPJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public NKCLOIOHHAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F8E0", Offset = "0x8E2ECE0", VA = "0x188E2F8E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F280", Offset = "0x8E2E680", VA = "0x188E2F280", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F230", Offset = "0x8E2E630", VA = "0x188E2F230")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F1E0", Offset = "0x8E2E5E0", VA = "0x188E2F1E0")]
		private void AIFLPGLABJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F790", Offset = "0x8E2EB90", VA = "0x188E2F790")]
		private void OAJBJDGKJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F890", Offset = "0x8E2EC90", VA = "0x188E2F890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F7E0", Offset = "0x8E2EBE0", VA = "0x188E2F7E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F7E0", Offset = "0x8E2EBE0", VA = "0x188E2F7E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BOBANFJLOOI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DFBCAKHBLPJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public BOBANFJLOOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EF00", Offset = "0x8E1E300", VA = "0x188E1EF00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EA90", Offset = "0x8E1DE90", VA = "0x188E1EA90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EA40", Offset = "0x8E1DE40", VA = "0x188E1EA40")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E9F0", Offset = "0x8E1DDF0", VA = "0x188E1E9F0")]
		private void AIFLPGLABJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EEB0", Offset = "0x8E1E2B0", VA = "0x188E1EEB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EE00", Offset = "0x8E1E200", VA = "0x188E1EE00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EE00", Offset = "0x8E1E200", VA = "0x188E1EE00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MIHILIACLNI NGAOMDMPJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<HDNJACNHKJE> KHANGDIOHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> ECLIFEEKCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer KEEHIMNBLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MDPOIEPFJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool ABIOLPDIHNA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<AHNPBENMMNA> IBBGHDMMBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HAJICLLBOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E21A10", Offset = "0x8E20E10", VA = "0x188E21A10", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GIJLHKFOFFB LBBEPBAEGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E20360", Offset = "0x8E1F760", VA = "0x188E20360", Slot = "8")]
		get
		{
			return default(GIJLHKFOFFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> LBNOAHCMAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8E219F0", Offset = "0x8E20DF0", VA = "0x188E219F0")]
	private bool LBDNJDICGII(HDNJACNHKJE PDPKIFONADM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8E20DB0", Offset = "0x8E201B0", VA = "0x188E20DB0")]
	private static bool DDDAAJOGIDK(HDNJACNHKJE PDPKIFONADM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8E21D40", Offset = "0x8E21140", VA = "0x188E21D40")]
	public DFBCAKHBLPJ(MIHILIACLNI NGIAGNLBILI, bool DJLMNABKHPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8E20DD0", Offset = "0x8E201D0", VA = "0x188E20DD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8E217B0", Offset = "0x8E20BB0", VA = "0x188E217B0")]
	public void KOBMLIBBKBO(HDNJACNHKJE PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8E20A60", Offset = "0x8E1FE60", VA = "0x188E20A60")]
	public void CBDHBFLGDII(HDNJACNHKJE PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8E20FC0", Offset = "0x8E203C0", VA = "0x188E20FC0", Slot = "4")]
	public void EHFOGHENOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8E21A50", Offset = "0x8E20E50", VA = "0x188E21A50")]
	public void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8E21540", Offset = "0x8E20940", VA = "0x188E21540")]
	private void FLEKFKNDPNN(List<HDNJACNHKJE> KHANGDIOHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8E20C80", Offset = "0x8E20080", VA = "0x188E20C80")]
	private static Material CNPBOOIJACP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8E21700", Offset = "0x8E20B00", VA = "0x188E21700")]
	private void FLEKFKNDPNN(HDNJACNHKJE PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8E20CE0", Offset = "0x8E200E0", VA = "0x188E20CE0")]
	private void DAECALDDFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8E20420", Offset = "0x8E1F820", VA = "0x188E20420")]
	public void AKLCBHIEDNN(bool EBPOEJEBKKF, bool FGBKCNFOPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8E20BC0", Offset = "0x8E1FFC0", VA = "0x188E20BC0")]
	protected void CJBJLLLCKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8E209E0", Offset = "0x8E1FDE0", VA = "0x188E209E0")]
	public void ALGIPJLFLNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8E21CC0", Offset = "0x8E210C0", VA = "0x188E21CC0")]
	[IteratorStateMachine(typeof(NKCLOIOHHAA))]
	public IEnumerable<Renderer> POEKJOCPPON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8E214C0", Offset = "0x8E208C0", VA = "0x188E214C0")]
	[IteratorStateMachine(typeof(BOBANFJLOOI))]
	public IEnumerable<Renderer> FCGNGEDELGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class JGLIAJHHDPE : HDNJACNHKJE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct AHOJFAIIPOK : POMBMDLOHDC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private CGCDLCFCEHB NIKBNBLEJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle EDPKGAKIIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MCCDJOJOLBF BOLNCNKLLPI;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E940", Offset = "0x8E1DD40", VA = "0x188E1E940")]
		public AHOJFAIIPOK(CGCDLCFCEHB NIKBNBLEJEO, JobHandle EDPKGAKIIHD, MCCDJOJOLBF BOLNCNKLLPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E8C0", Offset = "0x8E1DCC0", VA = "0x188E1E8C0", Slot = "4")]
		public CGCDLCFCEHB CEOCICHNPFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E8F0", Offset = "0x8E1DCF0", VA = "0x188E1E8F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly GGBCEOMBCDB PBIFFEKPHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float CPKNGBFDGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 CBOCMICPDJF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 DJADFPAMEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8E29110", Offset = "0x8E28510", VA = "0x188E29110", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8E2ABF0", Offset = "0x8E29FF0", VA = "0x188E2ABF0")]
	public JGLIAJHHDPE(DFBCAKHBLPJ LDEPDDDHLLO, GGBCEOMBCDB NGIAGNLBILI, bool DJLMNABKHPE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "18")]
	public override bool HNKMKPGAFIG(GIJLHKFOFFB LDEPDDDHLLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8E2A2F0", Offset = "0x8E296F0", VA = "0x188E2A2F0", Slot = "19")]
	public override int JIKCBGILJOG(FOBJPMBJJIL BFGBMBMPPGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8E29230", Offset = "0x8E28630", VA = "0x188E29230", Slot = "20")]
	public override int EIHFJLPNLDP(FOBJPMBJJIL BFGBMBMPPGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8E2A4D0", Offset = "0x8E298D0", VA = "0x188E2A4D0", Slot = "21")]
	public override NNCAMIFAKGI NOGOPDADBKF()
	{
		return default(NNCAMIFAKGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC1A7D0", Offset = "0xC19BD0", VA = "0x180C1A7D0", Slot = "22")]
	public override float BFAFBAMHNJF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8E29410", Offset = "0x8E28810", VA = "0x188E29410", Slot = "23")]
	public override void FBFKBOPNCGO(FOBJPMBJJIL BFGBMBMPPGG, GCHCCBCGNIE DCHKOPDBDFH, int INMODPJCNEO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8E29950", Offset = "0x8E28D50", VA = "0x188E29950")]
	private int HGCDPCDGMJH(FOBJPMBJJIL BFGBMBMPPGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8E29040", Offset = "0x8E28440", VA = "0x188E29040", Slot = "24")]
	public override GIJLHKFOFFB AFKPIFCJIJH()
	{
		return default(GIJLHKFOFFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8E2AA30", Offset = "0x8E29E30", VA = "0x188E2AA30", Slot = "26")]
	public override BNLIKPDBPCI PMKEBLGODEG()
	{
		return default(BNLIKPDBPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8E29B40", Offset = "0x8E28F40", VA = "0x188E29B40", Slot = "27")]
	public override POMBMDLOHDC IOIJAPNABEL(FOBJPMBJJIL BFGBMBMPPGG, JobHandle EDPKGAKIIHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface PPNEADJGHIP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DFBCAKHBLPJ FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HDNJACNHKJE FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DMDEHLPLEEP FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class NHBPJFDCGFN : KGMOHGCFKDB, IDisposable, PPNEADJGHIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JJCLHFGBNNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NHBPJFDCGFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8E2ACA0", Offset = "0x8E2A0A0", VA = "0x188E2ACA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8E2B220", Offset = "0x8E2A620", VA = "0x188E2B220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly FLFBGEFLFIN<NGNHPGHDKAF, DFBCAKHBLPJ> PNNFKANJDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly FLFBGEFLFIN<PGGHBPJAHOA, HDNJACNHKJE> KHANGDIOHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly FLFBGEFLFIN<HGFJKNIGNKF, DMDEHLPLEEP> MAIIPHHGJBH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DFBCAKHBLPJ FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8E2D5D0", Offset = "0x8E2C9D0", VA = "0x188E2D5D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HDNJACNHKJE FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8E2D570", Offset = "0x8E2C970", VA = "0x188E2D570", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DMDEHLPLEEP FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8E2D510", Offset = "0x8E2C910", VA = "0x188E2D510", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DFCEPOIJMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xBC1BC0", Offset = "0xBC0FC0", VA = "0x180BC1BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8E2ED30", Offset = "0x8E2E130", VA = "0x188E2ED30")]
	public NHBPJFDCGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8E2D2D0", Offset = "0x8E2C6D0", VA = "0x188E2D2D0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8E2E960", Offset = "0x8E2DD60", VA = "0x188E2E960", Slot = "4")]
	public NGNHPGHDKAF MFEEAGOEAGJ(MIHILIACLNI NGIAGNLBILI)
	{
		return default(NGNHPGHDKAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8E2E6E0", Offset = "0x8E2DAE0", VA = "0x188E2E6E0", Slot = "5")]
	public NGNHPGHDKAF MFEEAGOEAGJ(MIHILIACLNI NGIAGNLBILI, bool DJLMNABKHPE)
	{
		return default(NGNHPGHDKAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8E2E2C0", Offset = "0x8E2D6C0", VA = "0x188E2E2C0", Slot = "6")]
	public void JLLAILIMPJF(NGNHPGHDKAF LDEPDDDHLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8E2D930", Offset = "0x8E2CD30", VA = "0x188E2D930", Slot = "7")]
	public void HJOADFFNFNB(NGNHPGHDKAF LDEPDDDHLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8E2CB10", Offset = "0x8E2BF10", VA = "0x188E2CB10", Slot = "8")]
	public PGGHBPJAHOA AHKCAEKHEFG(NGNHPGHDKAF LDEPDDDHLLO, DDKMMPAGGHJ NGIAGNLBILI)
	{
		return default(PGGHBPJAHOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8E2DC90", Offset = "0x8E2D090", VA = "0x188E2DC90", Slot = "9")]
	public PGGHBPJAHOA IMCPDCMOLND(NGNHPGHDKAF LDEPDDDHLLO, GGBCEOMBCDB NGIAGNLBILI)
	{
		return default(PGGHBPJAHOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8E2E970", Offset = "0x8E2DD70", VA = "0x188E2E970", Slot = "11")]
	public void OJMEBJPPOBJ(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8E2CFF0", Offset = "0x8E2C3F0", VA = "0x188E2CFF0", Slot = "10")]
	public void BONIDJPOPMM(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8E2D4A0", Offset = "0x8E2C8A0", VA = "0x188E2D4A0", Slot = "20")]
	public IEnumerable<Renderer> ECEOONLJOMH(NGNHPGHDKAF LDEPDDDHLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8E2D250", Offset = "0x8E2C650", VA = "0x188E2D250", Slot = "12")]
	public HGFJKNIGNKF CANGDOCPCPJ(CEGHCFFMHKC NGIAGNLBILI)
	{
		return default(HGFJKNIGNKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8E2D630", Offset = "0x8E2CA30", VA = "0x188E2D630", Slot = "14")]
	public void FENDJELKAHL(HGFJKNIGNKF AIMCJDGDGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8E2D6A0", Offset = "0x8E2CAA0", VA = "0x188E2D6A0", Slot = "16")]
	public Task FMHBLFALEIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8E2E520", Offset = "0x8E2D920", VA = "0x188E2E520", Slot = "17")]
	public Task LCLBJCKBBKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8E2D860", Offset = "0x8E2CC60", VA = "0x188E2D860", Slot = "18")]
	[AsyncStateMachine(typeof(JJCLHFGBNNA))]
	public Task HAFBOBCCKOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8E2E170", Offset = "0x8E2D570", VA = "0x188E2E170", Slot = "19")]
	public void IPCPOFOBJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8E2E260", Offset = "0x8E2D660", VA = "0x188E2E260", Slot = "13")]
	public void JLHEMFKGKKF(HGFJKNIGNKF AIMCJDGDGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class EGHCLKEHFFJ : HDNJACNHKJE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct EBNEOBFHNNH : POMBMDLOHDC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private CGCDLCFCEHB NIKBNBLEJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> FENCFDCJHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle EDPKGAKIIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private BEAAMFKKPCJ BOLNCNKLLPI;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8E233B0", Offset = "0x8E227B0", VA = "0x188E233B0")]
		public EBNEOBFHNNH(CGCDLCFCEHB NIKBNBLEJEO, NativeArray<int> FENCFDCJHEP, JobHandle EDPKGAKIIHD, BEAAMFKKPCJ BOLNCNKLLPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8E232B0", Offset = "0x8E226B0", VA = "0x188E232B0", Slot = "4")]
		public CGCDLCFCEHB CEOCICHNPFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8E23310", Offset = "0x8E22710", VA = "0x188E23310", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly DDKMMPAGGHJ NMPPAMCHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] LBCAGBKHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 CBOCMICPDJF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 ELHKCGPJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8E241B0", Offset = "0x8E235B0", VA = "0x188E241B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 DJADFPAMEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8E23790", Offset = "0x8E22B90", VA = "0x188E23790", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8E25A10", Offset = "0x8E24E10", VA = "0x188E25A10")]
	public EGHCLKEHFFJ(DFBCAKHBLPJ LDEPDDDHLLO, DDKMMPAGGHJ NGIAGNLBILI, bool BHMDIPEFGNG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8E245E0", Offset = "0x8E239E0", VA = "0x188E245E0", Slot = "18")]
	public override bool HNKMKPGAFIG(GIJLHKFOFFB LDEPDDDHLLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8E251B0", Offset = "0x8E245B0", VA = "0x188E251B0", Slot = "21")]
	public override NNCAMIFAKGI NOGOPDADBKF()
	{
		return default(NNCAMIFAKGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8E251F0", Offset = "0x8E245F0", VA = "0x188E251F0")]
	private NNCAMIFAKGI NOGOPDADBKF(GIJLHKFOFFB LDEPDDDHLLO)
	{
		return default(NNCAMIFAKGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8E243E0", Offset = "0x8E237E0", VA = "0x188E243E0")]
	private GAJLNDDHAMD HLKAIHFKIHC([In] UniformTRS ENMAOKJKOOG, [In] float3 GAPOEDFJKKB)
	{
		return default(GAJLNDDHAMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8E24E80", Offset = "0x8E24280", VA = "0x188E24E80", Slot = "19")]
	public override int JIKCBGILJOG(FOBJPMBJJIL BFGBMBMPPGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8E238B0", Offset = "0x8E22CB0", VA = "0x188E238B0", Slot = "20")]
	public override int EIHFJLPNLDP(FOBJPMBJJIL BFGBMBMPPGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8E236A0", Offset = "0x8E22AA0", VA = "0x188E236A0", Slot = "22")]
	public override float BFAFBAMHNJF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8E24F30", Offset = "0x8E24330", VA = "0x188E24F30")]
	private int MGGGFOCNEPF(FOBJPMBJJIL BFGBMBMPPGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8E23960", Offset = "0x8E22D60", VA = "0x188E23960", Slot = "23")]
	public override void FBFKBOPNCGO(FOBJPMBJJIL BFGBMBMPPGG, GCHCCBCGNIE DCHKOPDBDFH, int INMODPJCNEO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8E235D0", Offset = "0x8E229D0", VA = "0x188E235D0", Slot = "24")]
	public override GIJLHKFOFFB AFKPIFCJIJH()
	{
		return default(GIJLHKFOFFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8E25850", Offset = "0x8E24C50", VA = "0x188E25850", Slot = "26")]
	public override BNLIKPDBPCI PMKEBLGODEG()
	{
		return default(BNLIKPDBPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8E246B0", Offset = "0x8E23AB0", VA = "0x188E246B0", Slot = "27")]
	public override POMBMDLOHDC IOIJAPNABEL(FOBJPMBJJIL BFGBMBMPPGG, JobHandle EDPKGAKIIHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JMHJEMBGPAA
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIPMOAKFIOJ(HGDKDFHGHAK IIHAKBEOLJD, Renderer FOGLHINMCEC, int IKBLOKPEDPF);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNIPDHPFCOC(Renderer FOGLHINMCEC, CPHNAPAEHAA DNGECPKMELJ, Vector3 HLIBNOGBFGB, Vector3 OHICJDDOEPF, Vector3 AKDIOJJKIOG, float JEFDODKPPEO, float MHACNFDBKLN, float ECJHGCMNIKO = -1f, [Optional] Color? IFBOGFLAOGG, [Optional] IReadOnlyList<Camera> JKNLIGGLALO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFKDFKMJMNJ(Renderer FOGLHINMCEC, int IKBLOKPEDPF);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BILLKPIFEEN();

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPCEPJFMAPJ(int NOGFKAGCHIC, MPJPIJDIFLM IIHAKBEOLJD, Renderer FOGLHINMCEC, int IKBLOKPEDPF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EMOGNCLCMGE : IEKGCOIIEHP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class BBAOOCAPAAC : GALEIMIIDFB<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E9A0", Offset = "0x8E1DDA0", VA = "0x188E1E9A0")]
		public BBAOOCAPAAC(string HDNPPEBJPAE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JMHJEMBGPAA IFHAPHAIOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PPNEADJGHIP MGIGIKLBPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer OBNOECALMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private BBAOOCAPAAC BNHPDBEMKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool PBBLHMMDPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer AABMOCDDOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private BBAOOCAPAAC HPKMDJDLIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool GLNKNHLCBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer JEEFCHDNNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private BBAOOCAPAAC BCJHDMBIAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool CNDNLPEOEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool GJNOCMLAONB;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	public EMOGNCLCMGE(JMHJEMBGPAA LGMBKMGAIMJ, PPNEADJGHIP MGIGIKLBPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8E25F30", Offset = "0x8E25330", VA = "0x188E25F30", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8E25CC0", Offset = "0x8E250C0", VA = "0x188E25CC0")]
	private void CAFHLHHLIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8E26FE0", Offset = "0x8E263E0", VA = "0x188E26FE0", Slot = "4")]
	public void MEFINHPDNKK(NGNHPGHDKAF LDEPDDDHLLO, MPJPIJDIFLM ODCHPDHAEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8E272F0", Offset = "0x8E266F0", VA = "0x188E272F0", Slot = "5")]
	public void MEFINHPDNKK(PGGHBPJAHOA PDPKIFONADM, MPJPIJDIFLM ODCHPDHAEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8E281D0", Offset = "0x8E275D0", VA = "0x188E281D0", Slot = "6")]
	public void OEGHIGKLGDE(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8E265F0", Offset = "0x8E259F0", VA = "0x188E265F0", Slot = "7")]
	public void JBCLKNBMKGD(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8E28330", Offset = "0x8E27730", VA = "0x188E28330", Slot = "24")]
	public void OFLEGPPEHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x13E8790", Offset = "0x13E7B90", VA = "0x1813E8790", Slot = "8")]
	public void IBEDOPKKEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8E26350", Offset = "0x8E25750", VA = "0x188E26350", Slot = "9")]
	public void IFFHCACLGGG(MPJPIJDIFLM ODCHPDHAEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8E269B0", Offset = "0x8E25DB0", VA = "0x188E269B0", Slot = "10")]
	public void LBFHCBBAPLH(NGNHPGHDKAF LDEPDDDHLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8E26C80", Offset = "0x8E26080", VA = "0x188E26C80", Slot = "11")]
	public void LBFHCBBAPLH(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8E27E20", Offset = "0x8E27220", VA = "0x188E27E20", Slot = "12")]
	public void ODHBLFFAGOP(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8E28370", Offset = "0x8E27770", VA = "0x188E28370", Slot = "13")]
	public void OLONGAIHCIK(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8E26740", Offset = "0x8E25B40", VA = "0x188E26740")]
	private void JCAMCCJLCLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xEA5610", Offset = "0xEA4A10", VA = "0x180EA5610", Slot = "14")]
	public void CJLKBFCKBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8E28440", Offset = "0x8E27840", VA = "0x188E28440", Slot = "15")]
	public void PGNKJFCHFGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8E27EF0", Offset = "0x8E272F0", VA = "0x188E27EF0", Slot = "16")]
	public void ODJMOENMFIF(NGNHPGHDKAF LDEPDDDHLLO, HGDKDFHGHAK IIHAKBEOLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8E27D50", Offset = "0x8E27150", VA = "0x188E27D50", Slot = "17")]
	public void OAHLGCBKCIP(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8E28560", Offset = "0x8E27960", VA = "0x188E28560", Slot = "18")]
	public void PLGJGLBPJAG(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xDC6260", Offset = "0xDC5660", VA = "0x180DC6260", Slot = "19")]
	public void HGDKODFIPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8E264C0", Offset = "0x8E258C0", VA = "0x188E264C0", Slot = "20")]
	public void INABJPCEADE(HGDKDFHGHAK IIHAKBEOLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8E260E0", Offset = "0x8E254E0", VA = "0x188E260E0")]
	private void ICGAECNCGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8E27990", Offset = "0x8E26D90", VA = "0x188E27990", Slot = "21")]
	public void NPMMPDOMHIB(NGNHPGHDKAF LDEPDDDHLLO, Vector3 HLIBNOGBFGB, Vector3 OHICJDDOEPF, Vector3 AKDIOJJKIOG, float JEFDODKPPEO, float MHACNFDBKLN, IReadOnlyList<Camera> HDIANDGMECO, CPHNAPAEHAA DNGECPKMELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8E27510", Offset = "0x8E26910", VA = "0x188E27510", Slot = "22")]
	public void NPMMPDOMHIB(HGFJKNIGNKF AIMCJDGDGHO, Vector3 HLIBNOGBFGB, Vector3 OHICJDDOEPF, Vector3 AKDIOJJKIOG, float JEFDODKPPEO, float MHACNFDBKLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class HDNJACNHKJE : DNJFHCEBNPA, AHNPBENMMNA, DMANLCMIPAP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly DFBCAKHBLPJ NDDFGLPMAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int KCHMENCNMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds AKFHMBCCNJO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds AIIPLAGEIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8E29020", Offset = "0x8E28420", VA = "0x188E29020", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool ABIOLPDIHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xEA8FB0", Offset = "0xEA83B0", VA = "0x180EA8FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xED2D00", Offset = "0xED2100", VA = "0x180ED2D00")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 DJADFPAMEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BBNJNJALOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xC11DD0", Offset = "0xC111D0", VA = "0x180C11DD0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public JEGHDOKHLDM MKPKJLNOMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EOPCNPBHFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x22A8390", Offset = "0x22A7790", VA = "0x1822A8390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	protected HDNJACNHKJE(DFBCAKHBLPJ LDEPDDDHLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8E28EA0", Offset = "0x8E282A0", VA = "0x188E28EA0", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "18")]
	public virtual bool HNKMKPGAFIG(GIJLHKFOFFB LDEPDDDHLLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8E29010", Offset = "0x8E28410", VA = "0x188E29010", Slot = "10")]
	public int KDABMFPALJP(int LOELKFAAMIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int JIKCBGILJOG(FOBJPMBJJIL BFGBMBMPPGG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int EIHFJLPNLDP(FOBJPMBJJIL BFGBMBMPPGG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract NNCAMIFAKGI NOGOPDADBKF();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float BFAFBAMHNJF();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void FBFKBOPNCGO(FOBJPMBJJIL BFGBMBMPPGG, GCHCCBCGNIE DCHKOPDBDFH, int INMODPJCNEO = -1);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract GIJLHKFOFFB AFKPIFCJIJH();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8E28E40", Offset = "0x8E28240", VA = "0x188E28E40", Slot = "13")]
	public Hash128 CJGHENMPGKH(int BFGBMBMPPGG)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract BNLIKPDBPCI PMKEBLGODEG();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract POMBMDLOHDC IOIJAPNABEL(FOBJPMBJJIL BFGBMBMPPGG, JobHandle EDPKGAKIIHD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8E28E70", Offset = "0x8E28270", VA = "0x188E28E70", Slot = "12")]
	public POMBMDLOHDC DENKEKDOEIA(int BFGBMBMPPGG)
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

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8E31650", Offset = "0x8E30A50", VA = "0x188E31650")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PJKECNAJMGL
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class EFAOOIBBPCO : IEnumerable<PEIGJKKLNNK>, IEnumerable, IEnumerator<PEIGJKKLNNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private PEIGJKKLNNK <>2__current;

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
		private PEIGJKKLNNK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public EFAOOIBBPCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8E23410", Offset = "0x8E22810", VA = "0x188E23410", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8E23580", Offset = "0x8E22980", VA = "0x188E23580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E234E0", Offset = "0x8E228E0", VA = "0x188E234E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PEIGJKKLNNK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E234E0", Offset = "0x8E228E0", VA = "0x188E234E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static PEIGJKKLNNK[][] CMHHPPCJECE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static NEAPFKDAPIL GDEKPAFDLOM;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig IFOKKMGGPEB;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader IHFOOJPACLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8E313A0", Offset = "0x8E307A0", VA = "0x188E313A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer FFOKGKOLMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8E31150", Offset = "0x8E30550", VA = "0x188E31150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8E31460", Offset = "0x8E30860", VA = "0x188E31460")]
	[CLKKFJPKILN]
	internal static void PJOFCLDPLJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8E2FEB0", Offset = "0x8E2F2B0", VA = "0x188E2FEB0")]
	public static Mesh BMGMBAIBOFM(INMHHAMFOKG AOPFCLLBCDM, int BFGBMBMPPGG = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8E31390", Offset = "0x8E30790", VA = "0x188E31390")]
	public static int KODDHIBMKIP(INMHHAMFOKG AOPFCLLBCDM, int BFGBMBMPPGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8E30F10", Offset = "0x8E30310", VA = "0x188E30F10")]
	public static NEAPFKDAPIL DJDAJGHBCEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8E31400", Offset = "0x8E30800", VA = "0x188E31400")]
	[IteratorStateMachine(typeof(EFAOOIBBPCO))]
	private static IEnumerable<PEIGJKKLNNK> LOKDCHHICIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8E30100", Offset = "0x8E2F500", VA = "0x188E30100")]
	public static PEIGJKKLNNK DEAHMBIOCDN(INMHHAMFOKG AOPFCLLBCDM, int BFGBMBMPPGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8E31130", Offset = "0x8E30530", VA = "0x188E31130")]
	public static bool FHHDNBCBJCK(this INMHHAMFOKG AOPFCLLBCDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8E2FF50", Offset = "0x8E2F350", VA = "0x188E2FF50")]
	public static void CNCNFMLJGBF(INMHHAMFOKG AOPFCLLBCDM, float3 COGPKKHHIFO, [Out] LFMODOJCHOJ CHFDFPDPFMI, [Out] float3 HAEEDHKHDHC, [Out] float JFCMDGBAPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8E2FAE0", Offset = "0x8E2EEE0", VA = "0x188E2FAE0")]
	public static void BLAHDNMJPPE(Vector3 COGPKKHHIFO, INMHHAMFOKG AOPFCLLBCDM, [Out] Vector3 HAEEDHKHDHC, [Out] float JFCMDGBAPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8E2FAD0", Offset = "0x8E2EED0", VA = "0x188E2FAD0")]
	[LEIPJKNOCEE(0)]
	[DIELKDJGIPF(LDIDCMPDDMG.ExitingPlayMode, 0)]
	private static void ALKOMLNBDKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8E311B0", Offset = "0x8E305B0", VA = "0x188E311B0")]
	[LEIPJKNOCEE(0)]
	[DIELKDJGIPF(LDIDCMPDDMG.ExitingPlayMode, 0)]
	private static void GMCBAMLFCDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class KOAOHIGCAJH : KGMOHGCFKDB, IDisposable, PPNEADJGHIP
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly FLFBGEFLFIN<NGNHPGHDKAF, DFBCAKHBLPJ> PNNFKANJDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly FLFBGEFLFIN<PGGHBPJAHOA, HDNJACNHKJE> KHANGDIOHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly FLFBGEFLFIN<HGFJKNIGNKF, DMDEHLPLEEP> MAIIPHHGJBH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public DFBCAKHBLPJ FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8E2B600", Offset = "0x8E2AA00", VA = "0x188E2B600", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HDNJACNHKJE FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E2B5A0", Offset = "0x8E2A9A0", VA = "0x188E2B5A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DMDEHLPLEEP FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8E2B660", Offset = "0x8E2AA60", VA = "0x188E2B660", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DFCEPOIJMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xBC1BC0", Offset = "0xBC0FC0", VA = "0x180BC1BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8E2BD50", Offset = "0x8E2B150", VA = "0x188E2BD50")]
	public KOAOHIGCAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8E2B4A0", Offset = "0x8E2A8A0", VA = "0x188E2B4A0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8E2BB90", Offset = "0x8E2AF90", VA = "0x188E2BB90", Slot = "4")]
	public NGNHPGHDKAF MFEEAGOEAGJ(MIHILIACLNI NGIAGNLBILI)
	{
		return default(NGNHPGHDKAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8E2BB90", Offset = "0x8E2AF90", VA = "0x188E2BB90", Slot = "5")]
	public NGNHPGHDKAF MFEEAGOEAGJ(MIHILIACLNI NGIAGNLBILI, bool DJLMNABKHPE)
	{
		return default(NGNHPGHDKAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8E2BA90", Offset = "0x8E2AE90", VA = "0x188E2BA90", Slot = "6")]
	public void JLLAILIMPJF(NGNHPGHDKAF LDEPDDDHLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8E2B870", Offset = "0x8E2AC70", VA = "0x188E2B870", Slot = "7")]
	public void HJOADFFNFNB(NGNHPGHDKAF LDEPDDDHLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8E2B280", Offset = "0x8E2A680", VA = "0x188E2B280", Slot = "8")]
	public PGGHBPJAHOA AHKCAEKHEFG(NGNHPGHDKAF LDEPDDDHLLO, DDKMMPAGGHJ NGIAGNLBILI)
	{
		return default(PGGHBPJAHOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8E2B8F0", Offset = "0x8E2ACF0", VA = "0x188E2B8F0", Slot = "9")]
	public PGGHBPJAHOA IMCPDCMOLND(NGNHPGHDKAF LDEPDDDHLLO, GGBCEOMBCDB NGIAGNLBILI)
	{
		return default(PGGHBPJAHOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8E2BC30", Offset = "0x8E2B030", VA = "0x188E2BC30", Slot = "11")]
	public void OJMEBJPPOBJ(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8E2B3C0", Offset = "0x8E2A7C0", VA = "0x188E2B3C0", Slot = "10")]
	public void BONIDJPOPMM(PGGHBPJAHOA PDPKIFONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8E2B530", Offset = "0x8E2A930", VA = "0x188E2B530", Slot = "20")]
	public IEnumerable<Renderer> ECEOONLJOMH(NGNHPGHDKAF LDEPDDDHLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8E2B420", Offset = "0x8E2A820", VA = "0x188E2B420", Slot = "12")]
	public HGFJKNIGNKF CANGDOCPCPJ(CEGHCFFMHKC NGIAGNLBILI)
	{
		return default(HGFJKNIGNKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8E2B6C0", Offset = "0x8E2AAC0", VA = "0x188E2B6C0", Slot = "14")]
	public void FENDJELKAHL(HGFJKNIGNKF AIMCJDGDGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8E2B730", Offset = "0x8E2AB30", VA = "0x188E2B730", Slot = "16")]
	public Task FMHBLFALEIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8E2BAF0", Offset = "0x8E2AEF0", VA = "0x188E2BAF0", Slot = "17")]
	public Task LCLBJCKBBKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8E2B7D0", Offset = "0x8E2ABD0", VA = "0x188E2B7D0", Slot = "18")]
	public Task HAFBOBCCKOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x294E1F0", Offset = "0x294D5F0", VA = "0x18294E1F0", Slot = "19")]
	public void IPCPOFOBJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8E2BA30", Offset = "0x8E2AE30", VA = "0x188E2BA30", Slot = "13")]
	public void JLHEMFKGKKF(HGFJKNIGNKF AIMCJDGDGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface AJNOKCEKKIF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool MJMCFDIGBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material JPPIIENMLDN();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material CNPBOOIJACP();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material EFKEFHKJMDE();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EALFPNCBHEE(HOPHEEHHBNP MPDMCOLCMID);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JMEKJGNFFLP(BMPAPPBHELN HPMPNEBHMDH);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOIPGMHEHBG(GameObject DEJGDIIDCDN);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BMCAHAACENP(GameObject DEJGDIIDCDN, bool HCOMAOEHNBG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FACHBNMAIGJ
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AJNOKCEKKIF FCHDCHMAIKA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool MJMCFDIGBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8E28910", Offset = "0x8E27D10", VA = "0x188E28910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8E287E0", Offset = "0x8E27BE0", VA = "0x188E287E0")]
	public static void EKADNGOEGKO(AJNOKCEKKIF KJKNCNIIFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8E289E0", Offset = "0x8E27DE0", VA = "0x188E289E0")]
	public static Material JPPIIENMLDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8E20C80", Offset = "0x8E20080", VA = "0x188E20C80")]
	public static Material CNPBOOIJACP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8E28780", Offset = "0x8E27B80", VA = "0x188E28780")]
	public static Material EFKEFHKJMDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8E28710", Offset = "0x8E27B10", VA = "0x188E28710")]
	public static int EALFPNCBHEE(HOPHEEHHBNP MPDMCOLCMID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8E28970", Offset = "0x8E27D70", VA = "0x188E28970")]
	public static int JMEKJGNFFLP(BMPAPPBHELN HPMPNEBHMDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8E28840", Offset = "0x8E27C40", VA = "0x188E28840")]
	public static void EOIPGMHEHBG(GameObject DEJGDIIDCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8E28630", Offset = "0x8E27A30", VA = "0x188E28630")]
	public static void BMCAHAACENP(GameObject DEJGDIIDCDN, bool HCOMAOEHNBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DMDEHLPLEEP : PHAPANCEJFN
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FAOLJMNHDCN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DMDEHLPLEEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public FAOLJMNHDCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8E28DB0", Offset = "0x8E281B0", VA = "0x188E28DB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8E28A90", Offset = "0x8E27E90", VA = "0x188E28A90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8E28A40", Offset = "0x8E27E40", VA = "0x188E28A40")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8E28D60", Offset = "0x8E28160", VA = "0x188E28D60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8E28CB0", Offset = "0x8E280B0", VA = "0x188E28CB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8E28CB0", Offset = "0x8E280B0", VA = "0x188E28CB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CEGHCFFMHKC KHOPHODNDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly PPNEADJGHIP MGIGIKLBPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private LKFDBNECOFA OIKKHMPKEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<CLNOEEGCPGP> MCKKGAHPDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<CLNOEEGCPGP> JJKLAGFHCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject ILAHALPJBGE;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8E21E30", Offset = "0x8E21230", VA = "0x188E21E30")]
	public static DMDEHLPLEEP CBIPADKKCBD(CEGHCFFMHKC NGIAGNLBILI, PPNEADJGHIP MGIGIKLBPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8E231D0", Offset = "0x8E225D0", VA = "0x188E231D0")]
	private DMDEHLPLEEP(CEGHCFFMHKC NGIAGNLBILI, PPNEADJGHIP MGIGIKLBPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8E22A70", Offset = "0x8E21E70", VA = "0x188E22A70")]
	public void HNJLALOFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8E23150", Offset = "0x8E22550", VA = "0x188E23150")]
	[IteratorStateMachine(typeof(FAOLJMNHDCN))]
	public IEnumerable<Renderer> POEKJOCPPON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8E21FB0", Offset = "0x8E213B0", VA = "0x188E21FB0", Slot = "4")]
	public void EHFOGHENOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8E21F80", Offset = "0x8E21380", VA = "0x188E21F80")]
	private void EAEMPFDOCFB(Vector3 ALEAEKJGEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8E22F00", Offset = "0x8E22300", VA = "0x188E22F00")]
	public void OGELNPLKAMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CLNOEEGCPGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct HDEHEIIEDOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public GCHCCBCGNIE OKGDNBKHMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GIJLHKFOFFB CFANMBACANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int CDCNFCCFCOL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EJFLGBOIIKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public CLNOEEGCPGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public FOBJPMBJJIL lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<HDEHEIIEDOC> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CGCDLCFCEHB combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EJFLGBOIIKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8E25AC0", Offset = "0x8E24EC0", VA = "0x188E25AC0")]
		internal JobHandle CHCOOHFKFHN()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8E25C90", Offset = "0x8E25090", VA = "0x188E25C90")]
		internal void KAGNNAFOLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8E25B20", Offset = "0x8E24F20", VA = "0x188E25B20")]
		internal void HKLHKANHPGC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] OPCMOHLNDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private MMHIHICILKJ EOGCOKMPGEJ;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 ONEEANLCEHH;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh GEGAOALOAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int FDPLHEOFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8E1FBB0", Offset = "0x8E1EFB0", VA = "0x188E1FBB0")]
	public void PINPOCODBGN(List<GIJLHKFOFFB> EBGJNDDAMEG, Matrix4x4[] LOMLODFHPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8E1F030", Offset = "0x8E1E430", VA = "0x188E1F030")]
	public static List<CLNOEEGCPGP> CEOONNIFPHP(List<DFBCAKHBLPJ> INJLGLGBJCB, FOBJPMBJJIL BFGBMBMPPGG, Bounds EFDPEDFEFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8E1F840", Offset = "0x8E1EC40", VA = "0x188E1F840")]
	private JobHandle LADMKFLMHHH(CGCDLCFCEHB NGBGANDHPGI, int IHNMIEEEPLH, int PFPBLIFJJFD, FOBJPMBJJIL BFGBMBMPPGG, List<HDEHEIIEDOC> ACEEODGLOAE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8E1F760", Offset = "0x8E1EB60", VA = "0x188E1F760")]
	private void ENJDPNPPJND(List<HDEHEIIEDOC> ACEEODGLOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8E1FF40", Offset = "0x8E1F340", VA = "0x188E1FF40")]
	private CLNOEEGCPGP(List<HDEHEIIEDOC> ACEEODGLOAE, int IHNMIEEEPLH, int PFPBLIFJJFD, FOBJPMBJJIL BFGBMBMPPGG, Bounds EFDPEDFEFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8E1F6C0", Offset = "0x8E1EAC0", VA = "0x188E1F6C0", Slot = "4")]
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
		private MaterialPropertyBlock IPFJJAOFFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private CLNOEEGCPGP NIKBNBLEJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<GIJLHKFOFFB> CAHEAFKKKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture NOGMMGCIHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer CAGODMDKLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader NBNMKMBJFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] HEELOFKPDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int KANMCPNHPKJ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer LDOKHAFHOBM
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int NNDHDJIEFKB
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8E323E0", Offset = "0x8E317E0", VA = "0x188E323E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8E31770", Offset = "0x8E30B70", VA = "0x188E31770")]
		public static List<SkinnedShapeRenderer> Create(GameObject LDEPDDDHLLO, List<CLNOEEGCPGP> LCOEDLEMBLE, List<GIJLHKFOFFB> CAHEAFKKKBK, Material GMFBEMFEGJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8E31A60", Offset = "0x8E30E60", VA = "0x188E31A60")]
		public void Init(CLNOEEGCPGP NIKBNBLEJEO, List<GIJLHKFOFFB> CAHEAFKKKBK, Material GMFBEMFEGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8E31FD0", Offset = "0x8E313D0", VA = "0x188E31FD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8E31F30", Offset = "0x8E31330", VA = "0x188E31F30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8E31EF0", Offset = "0x8E312F0", VA = "0x188E31EF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8E316B0", Offset = "0x8E30AB0", VA = "0x188E316B0")]
		private void AEIEPHKFANE(ScriptableRenderContext HFJHENFIDEF, Camera[] OOMIIOOFMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8E32070", Offset = "0x8E31470", VA = "0x188E32070")]
		private void PINPOCODBGN(CommandBuffer BNKGCCLNMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
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
