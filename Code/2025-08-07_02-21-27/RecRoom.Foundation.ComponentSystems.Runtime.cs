using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89FD5F0", Offset = "0x89FC1F0", VA = "0x1889FD5F0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class DZISONAGUEP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
	public DZISONAGUEP()
	{
	}
}
namespace RecRoom.Foundation.ComponentSystems
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class XAGCBYABYYO : ESJNNHMNNAW
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89FDA40", Offset = "0x89FC640", VA = "0x1889FDA40", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract ComponentSystemBase ZDMLVAEWUEN();

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89FD9A0", Offset = "0x89FC5A0", VA = "0x1889FD9A0")]
		protected ESJNNHMNNAW Group(params ComponentSystemBase[] systems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89FD920", Offset = "0x89FC520", VA = "0x1889FD920")]
		protected ESJNNHMNNAW Group(string name, params ComponentSystemBase[] systems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x41C4D10", Offset = "0x41C3910", VA = "0x1841C4D10")]
		protected ESJNNHMNNAW Group<T>(params ComponentSystemBase[] systems) where T : ESJNNHMNNAW, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x41C4CB0", Offset = "0x41C38B0", VA = "0x1841C4CB0")]
		protected b FQLTMRUZSZN<b>() where b : ComponentSystemBase, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x41C4E90", Offset = "0x41C3A90", VA = "0x1841C4E90")]
		protected c YDPAHDBBWSS<c>() where c : ComponentSystemBase, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89FD880", Offset = "0x89FC480", VA = "0x1889FD880")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void CJLJHQHVBCW(ComponentSystemBase a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89FC890", Offset = "0x89FB490", VA = "0x1889FC890")]
		[Preserve]
		protected XAGCBYABYYO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MRBFEYCTJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x89FD530", Offset = "0x89FC130", VA = "0x1889FD530")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void GUATTBZEHBV(this ComponentSystemBase a, ComponentSystemGroup b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface XIKXBUEXYSC
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		ComponentSystemGroup MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ESJNNHMNNAW : LLVLLABXILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x89FC860", Offset = "0x89FB460", VA = "0x1889FC860", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89FC890", Offset = "0x89FB490", VA = "0x1889FC890")]
		[Preserve]
		public ESJNNHMNNAW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public abstract class LLVLLABXILC : ComponentSystemGroup, XIKXBUEXYSC
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ComponentSystemGroup? MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB1D720", Offset = "0xB1C320", VA = "0x180B1D720", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB73950", Offset = "0xB72550", VA = "0x180B73950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private string XVWNDFVXHMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x89FD420", Offset = "0x89FC020", VA = "0x1889FD420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x89FD460", Offset = "0x89FC060", VA = "0x1889FD460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x89FC890", Offset = "0x89FB490", VA = "0x1889FC890")]
		[Preserve]
		protected LLVLLABXILC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[SourceGenerate]
	[DebuggerTypeProxy(typeof(LFYXMYMYPGQ))]
	public abstract class IHLTZBLKFXI : SystemBase, XIKXBUEXYSC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct System
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct Managed
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct Unmanaged
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public struct Group : IEnumerable<System>, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x89FC8A0", Offset = "0x89FB4A0", VA = "0x1889FC8A0", Slot = "4")]
			public IEnumerator<System> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x89FC8E0", Offset = "0x89FB4E0", VA = "0x1889FC8E0", Slot = "5")]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal ComponentSystemBase[] QMTLFYKLGQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal UnsafeList<SystemHandle> MWNGRMGSAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal UnsafeList<Unity.Entities.UpdateIndex> GVDJATUJYGX;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool YYRRWXZPXQH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xBB3CE0", Offset = "0xBB28E0", VA = "0x180BB3CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D50", Offset = "0xBB2950", VA = "0x180BB3D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ComponentSystemGroup MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB131B0", Offset = "0xB11DB0", VA = "0x180B131B0", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x89FCF20", Offset = "0x89FBB20", VA = "0x1889FCF20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89FCAA0", Offset = "0x89FB6A0", VA = "0x1889FCAA0", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x89FCAD0", Offset = "0x89FB6D0", VA = "0x1889FCAD0", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89FCB40", Offset = "0x89FB740", VA = "0x1889FCB40", Slot = "13")]
		[Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
		[Preserve]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
		[Preserve]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89FCBE0", Offset = "0x89FB7E0", VA = "0x1889FCBE0")]
		private void PVKFIWULRIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x89FC8F0", Offset = "0x89FB4F0", VA = "0x1889FC8F0")]
		protected void JPTXEWUNHZZ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x89FCFD0", Offset = "0x89FBBD0", VA = "0x1889FCFD0", Slot = "16")]
		protected virtual void ZDMLVAEWUEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89FCA50", Offset = "0x89FB650", VA = "0x1889FCA50", Slot = "17")]
		protected virtual void MGLBFZURLOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4F80", Offset = "0x3BF3B80", VA = "0x183BF4F80")]
		protected a GJXKHJQIEVH<a>(int a, int b, a c) where a : ComponentSystemBase
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4C70", Offset = "0x3BF3870", VA = "0x183BF4C70")]
		protected b BSHWKBJJUSL<b>(int a, int b) where b : ComponentSystemBase
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5190", Offset = "0x3BF3D90", VA = "0x183BF5190")]
		protected void OLTGWVFTJTA<T>(int a, int b) where T : struct, ISystem
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		protected void DPXUNKAUBKZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		protected void WGODCMYTMSR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4D90", Offset = "0x3BF3990", VA = "0x183BF4D90")]
		public bool CYJEHYAIYYN<c>(int a, c b) where c : ComponentSystemBase
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x89FCC70", Offset = "0x89FB870", VA = "0x1889FCC70")]
		public bool SXKGGEEEQVS(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3087E60", Offset = "0x3086A60", VA = "0x183087E60")]
		[Preserve]
		protected IHLTZBLKFXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class LFYXMYMYPGQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct FinalVersionData<T> : IDisposable where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private VersionData<T> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public VersionData<T> RCOUNCRJCZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0")]
			get
			{
				return default(VersionData<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5336AF0", Offset = "0x53356F0", VA = "0x185336AF0")]
		public FinalVersionData(VersionData<T> version, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5335A10", Offset = "0x5334610", VA = "0x185335A10", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct FinalVersionInfo<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private VersionInfo<T> version;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5338B70", Offset = "0x5337770", VA = "0x185338B70")]
		public FinalVersionInfo(VersionInfo<T> version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5337FB0", Offset = "0x5336BB0", VA = "0x185337FB0")]
		public FinalVersionData<T> Allocate()
		{
			return default(FinalVersionData<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct IntermediateVersionData<T> : IDisposable where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private VersionData<T> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public VersionData<T> RCOUNCRJCZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0")]
			get
			{
				return default(VersionData<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5336AF0", Offset = "0x53356F0", VA = "0x185336AF0")]
		public IntermediateVersionData(VersionData<T> version, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x55B9A80", Offset = "0x55B8680", VA = "0x1855B9A80")]
		public void XDVAPMADGJO(VersionInfo<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x55B8FD0", Offset = "0x55B7BD0", VA = "0x1855B8FD0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct IntermediateVersionInfo<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private VersionInfo<T> version;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5338B70", Offset = "0x5337770", VA = "0x185338B70")]
		public IntermediateVersionInfo(VersionInfo<T> version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x55E1400", Offset = "0x55E0000", VA = "0x1855E1400")]
		public IntermediateVersionData<T> UPDSNMJZKTL()
		{
			return default(IntermediateVersionData<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	public abstract class KJMOKSVJOGK : SystemBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class TCPIQNKCSSB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public string DJKCHTJVTMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Func<(string typeName, EntityQuery query, int index), object> VNPNSVZAKTC;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TCPIQNKCSSB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x89FD670", Offset = "0x89FC270", VA = "0x1889FD670")]
			internal object GXHKXYXVRKR((string typeName, EntityQuery query, int index) a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private EntityCommandBufferSystem MZMEVPLXHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NativeList<EntityQuery> POGYIRAXQUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private bool YKWHUIBYPXA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public EntityCommandBufferSystem FSRVLWOAVZS
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected abstract Log NPHEYIXDMFH
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected bool HJSDDFNTWQO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x80BD8E0", Offset = "0x80BC4E0", VA = "0x1880BD8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
		public void PTZZRBMBHUE(EntityCommandBufferSystem a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89FD020", Offset = "0x89FBC20", VA = "0x1889FD020", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89FD100", Offset = "0x89FBD00", VA = "0x1889FD100", Slot = "13")]
		[Preserve]
		protected sealed override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x89FD0B0", Offset = "0x89FBCB0", VA = "0x1889FD0B0", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract void FIFFBOFXCTW();

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3C76200", Offset = "0x3C74E00", VA = "0x183C76200")]
		protected EntityQuery OXJAFEVCPQZ<T>() where T : struct, IComponentData
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C75A10", Offset = "0x3C74610", VA = "0x183C75A10")]
		protected IntermediateVersionInfo<T> CYNTSAKOWSG<T>() where T : struct, IComponentData
		{
			return default(IntermediateVersionInfo<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C76480", Offset = "0x3C75080", VA = "0x183C76480")]
		protected FinalVersionInfo<T> WZYLZPUHCIP<T>() where T : struct, IComponentData
		{
			return default(FinalVersionInfo<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x89FD170", Offset = "0x89FBD70", VA = "0x1889FD170")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void QMGZVWUKKTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3087E60", Offset = "0x3086A60", VA = "0x183087E60")]
		[Preserve]
		protected KJMOKSVJOGK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct VersionData<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NativeList<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NativeList<T> data;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int TXICYPISMOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6D09AC0", Offset = "0x6D086C0", VA = "0x186D09AC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (Entity entity, T value) this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B470", Offset = "0x6D0A070", VA = "0x186D0B470")]
			get
			{
				return default((Entity, T));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6D095A0", Offset = "0x6D081A0", VA = "0x186D095A0")]
		public void Add(Entity entity, T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct VersionInfo<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Unity.Collections.ReadOnly]
		public EntityQueryInJob query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Unity.Collections.ReadOnly]
		public EntityTypeHandle entityTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Unity.Collections.ReadOnly]
		public ComponentTypeHandle<T> componentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[WriteOnly]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AllocatorManager.AllocatorHandle allocator;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6D0DE40", Offset = "0x6D0CA40", VA = "0x186D0DE40")]
		public VersionData<T> Allocate()
		{
			return default(VersionData<T>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal class YXZKLZXAVUR
{
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
