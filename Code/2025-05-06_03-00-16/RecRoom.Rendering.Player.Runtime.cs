using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82A7FF0", Offset = "0x82A67F0", VA = "0x1882A7FF0", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2025EF0", Offset = "0x20246F0", VA = "0x182025EF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82A8FA0", Offset = "0x82A77A0", VA = "0x1882A8FA0")]
		private void BEJJPGDKNLF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82A93C0", Offset = "0x82A7BC0", VA = "0x1882A93C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82A91F0", Offset = "0x82A79F0", VA = "0x1882A91F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82A9420", Offset = "0x82A7C20", VA = "0x1882A9420")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(OLKBBMINLDE), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class OLKBBMINLDE : PDJPDJMINDB, JPHALCNLDIO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class DGBNKIAOCON : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IGCELENFGND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public OLKBBMINLDE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public DGBNKIAOCON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82A7270", Offset = "0x82A5A70", VA = "0x1882A7270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82A7490", Offset = "0x82A5C90", VA = "0x1882A7490", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ENFFENPOJNE BFFCDMJMCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KGOPFPAOFEK LMEEOKLPKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable NEGHFOOIFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable BBNIMEIIMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> KPOLGNICJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool DONFEDGHLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool ADBAMILIDLC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82A8F10", Offset = "0x82A7710", VA = "0x1882A8F10")]
	[UnityEngine.Scripting.Preserve]
	public OLKBBMINLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82A8B30", Offset = "0x82A7330", VA = "0x1882A8B30", Slot = "4")]
	public void LCFJNJCMKGC(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82A8510", Offset = "0x82A6D10", VA = "0x1882A8510")]
	private void ILFFDEAHLHD(Scene AIIEILNFBDK, LoadSceneMode ENCMJGPIOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82A80C0", Offset = "0x82A68C0", VA = "0x1882A80C0")]
	private void DGOGHFJKEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82A8520", Offset = "0x82A6D20", VA = "0x1882A8520")]
	private void JHOKNEGJMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x82A8350", Offset = "0x82A6B50", VA = "0x1882A8350")]
	private (ReflectionProbe, int) EDGKMFPEBBA()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82A8DE0", Offset = "0x82A75E0", VA = "0x1882A8DE0")]
	[IteratorStateMachine(typeof(DGBNKIAOCON))]
	private IEnumerator<IGCELENFGND> NABDNJIIAAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82A8CB0", Offset = "0x82A74B0", VA = "0x1882A8CB0")]
	private void LOMAEIFJGDG([CanBeNull] ReflectionProbe CMKNBNOEJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82A8E60", Offset = "0x82A7660", VA = "0x1882A8E60")]
	private void PCHMHCKPOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82A8D90", Offset = "0x82A7590", VA = "0x1882A8D90")]
	private void LPOMJHFEPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82A8270", Offset = "0x82A6A70", VA = "0x1882A8270", Slot = "5")]
	public void DPMOIAAKAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82A8600", Offset = "0x82A6E00", VA = "0x1882A8600")]
	[CompilerGenerated]
	private void KCDHDANJEHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ENFFENPOJNE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? DKACMEGLPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool CLONAGPJEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGLCMFDFLPB();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LPHLAEEPKIA : ENFFENPOJNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string IJJNDKOPFIH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string PAPJGNLOCBI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string HNDEBFMMPHI;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string KPHIILIKEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private MKLIBFLPPKJ EENCCKHNKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? LLKHMNPPIDJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? DKACMEGLPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CLONAGPJEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E10", Offset = "0x9DF610", VA = "0x1809E0E10")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	[UnityEngine.Scripting.Preserve]
	public LPHLAEEPKIA([NotNull][LDAFGEHKDJK(null)] MKLIBFLPPKJ ANGPHDLCABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82A74E0", Offset = "0x82A5CE0", VA = "0x1882A74E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82A7BA0", Offset = "0x82A63A0", VA = "0x1882A7BA0")]
	[PJMOOJOMMCC.IIIJEBEMPMI.HIHGDIHOODG]
	[UsedImplicitly]
	public static void LGPCFHDOFDP(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x82A7CA0", Offset = "0x82A64A0", VA = "0x1882A7CA0", Slot = "5")]
	public void OGLCMFDFLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x82A75E0", Offset = "0x82A5DE0", VA = "0x1882A75E0")]
	private void HBCHHKICPKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82A7DA0", Offset = "0x82A65A0", VA = "0x1882A7DA0")]
	private bool OPJIHKFMKAJ(string DPNLOEMONOC, [Out] IENFKPOMBKF ECFCOGDAPBG)
	{
		return default(bool);
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
