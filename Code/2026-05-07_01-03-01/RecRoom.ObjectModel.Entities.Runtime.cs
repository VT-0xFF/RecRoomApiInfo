using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.ComponentSystems;
using RecRoom.NoEngine.JetBrains.Annotations;
using RecRoom.ObjectModel.Entities;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x99FB110", Offset = "0x99F9B10", VA = "0x1899FB110")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class TMRYTQGXOHE
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

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
	public TMRYTQGXOHE()
	{
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99FA920", Offset = "0x99F9320", VA = "0x1899FA920")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface QEHAEODPHAN : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TokenHandle TokenHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ORXYSPVQDKZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SIGFKXXEIQE(Entity a, object b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VYQTYMPUQZX(Entity a, object b, [Out] bool c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MABTBGBNKZM(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class UCNUSXFCIFG<a, b> : WCWSIPENHGG<b>, IDisposable where a : struct, QEHAEODPHAN
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class KPHYRRDUTSZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private List<(object token, b value)> EXQWSLLXLKU;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int KQOHZIVUHAP
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x2836230", Offset = "0x2834C30", VA = "0x182836230")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6842970", Offset = "0x6841370", VA = "0x186842970")]
			public bool PQZVJPDSGRT([Out] b a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6842600", Offset = "0x6841000", VA = "0x186842600")]
			public void Add(object token, b value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6842BB0", Offset = "0x68415B0", VA = "0x186842BB0")]
			public bool Remove(object token)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x68428D0", Offset = "0x68412D0", VA = "0x1868428D0")]
			public int JZUFNJECDTX(object a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6842D00", Offset = "0x6841700", VA = "0x186842D00")]
			public KPHYRRDUTSZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Stack<KPHYRRDUTSZ> JIVHIHTYYDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ManagedObjectPool<TokenHandle, KPHYRRDUTSZ> UDJIEWRZKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private EntityManager STZUAVAWWUG;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5A50", Offset = "0x7DA4450", VA = "0x187DA5A50")]
		public UCNUSXFCIFG(EntityManager a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5030", Offset = "0x7DA3A30", VA = "0x187DA5030", Slot = "4")]
		public void SIGFKXXEIQE(Entity a, object b, b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5880", Offset = "0x7DA4280", VA = "0x187DA5880", Slot = "5")]
		public bool VYQTYMPUQZX(Entity a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4CA0", Offset = "0x7DA36A0", VA = "0x187DA4CA0", Slot = "6")]
		public bool PQZVJPDSGRT(Entity a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4850", Offset = "0x7DA3250", VA = "0x187DA4850", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4B60", Offset = "0x7DA3560", VA = "0x187DA4B60")]
		private void NPOUBGWJTEH(KPHYRRDUTSZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4870", Offset = "0x7DA3270", VA = "0x187DA4870")]
		private bool KKNYGFUQTCB(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7DA55D0", Offset = "0x7DA3FD0", VA = "0x187DA55D0")]
		private void UPHXOAXVIKR(Entity a, TokenHandle b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4DA0", Offset = "0x7DA37A0", VA = "0x187DA4DA0")]
		private bool PSSVPAMFCKD(TokenHandle a, [Out] KPHYRRDUTSZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7DA51E0", Offset = "0x7DA3BE0", VA = "0x187DA51E0")]
		private KPHYRRDUTSZ TETSMGHNYMT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface WCWSIPENHGG<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SIGFKXXEIQE(Entity a, object b, a c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VYQTYMPUQZX(Entity a, object b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PQZVJPDSGRT(Entity a, [Out] a b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct TokenHandle : KIWRLLDVYGF, IEquatable<TokenHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly TokenHandle Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xF535F0", Offset = "0xF51FF0", VA = "0x180F535F0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[CreateProperty]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x30B9B60", Offset = "0x30B8560", VA = "0x1830B9B60", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x30B9B70", Offset = "0x30B8570", VA = "0x1830B9B70", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99FB720", Offset = "0x99FA120", VA = "0x1899FB720", Slot = "8")]
		public bool Equals(TokenHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99FB770", Offset = "0x99FA170", VA = "0x1899FB770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class NJJTXJWOHPH<a> : ORXYSPVQDKZ, IDisposable where a : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Dictionary<Entity, TokenHandle> YESLHPKGVTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Stack<HashSet<object>> JIVHIHTYYDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ManagedObjectPool<TokenHandle, HashSet<object>> UDJIEWRZKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EntityManager STZUAVAWWUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private EntityCommandBufferSystem PINZCLHGKKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool MLELKNOQAUT;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x71AA140", Offset = "0x71A8B40", VA = "0x1871AA140")]
		public NJJTXJWOHPH(EntityManager a, EntityCommandBufferSystem b, Log c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x71A7970", Offset = "0x71A6370", VA = "0x1871A7970", Slot = "4")]
		public bool SIGFKXXEIQE(Entity a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71A99A0", Offset = "0x71A83A0", VA = "0x1871A99A0", Slot = "5")]
		public bool VYQTYMPUQZX(Entity a, object b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71A6520", Offset = "0x71A4F20", VA = "0x1871A6520", Slot = "6")]
		public bool MABTBGBNKZM(Entity a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71A63C0", Offset = "0x71A4DC0", VA = "0x1871A63C0", Slot = "8")]
		public bool MABTBGBNKZM(TokenHandle a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71A5CD0", Offset = "0x71A46D0", VA = "0x1871A5CD0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71A6E60", Offset = "0x71A5860", VA = "0x1871A6E60")]
		private void NPOUBGWJTEH(HashSet<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x71A5F70", Offset = "0x71A4970", VA = "0x1871A5F70")]
		private bool KKNYGFUQTCB(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x71A7FB0", Offset = "0x71A69B0", VA = "0x1871A7FB0")]
		private bool SNOSFUSQHVV(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x71A8DC0", Offset = "0x71A77C0", VA = "0x1871A8DC0")]
		private void USVNIWSLEEG(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x71A6B80", Offset = "0x71A5580", VA = "0x1871A6B80")]
		private void NPFSROXDPDX(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71A84E0", Offset = "0x71A6EE0", VA = "0x1871A84E0")]
		private void UEQHQUYJULE(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71A8AA0", Offset = "0x71A74A0", VA = "0x1871A8AA0")]
		private void UPHXOAXVIKR(Entity a, TokenHandle b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x71A9340", Offset = "0x71A7D40", VA = "0x1871A9340")]
		private bool UWQSBZUVHAI(TokenHandle a, [Out] HashSet<object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x71A8300", Offset = "0x71A6D00", VA = "0x1871A8300")]
		private HashSet<object> TETSMGHNYMT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class CZWEOFXXQME
	{
	}
}
namespace RecRoom.ObjectModel.Mappers
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct Float3GetX : HHATZIKGBQL<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x57718E0", Offset = "0x57702E0", VA = "0x1857718E0")]
		public float KUNUVPUSRXA([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x57718E0", Offset = "0x57702E0", VA = "0x1857718E0", Slot = "4")]
		private float WIIBPKNSYVC([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct Float3GetY : HHATZIKGBQL<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99FA9C0", Offset = "0x99F93C0", VA = "0x1899FA9C0")]
		public float KUNUVPUSRXA([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99FA9C0", Offset = "0x99F93C0", VA = "0x1899FA9C0", Slot = "4")]
		private float WIIBPKNSYVC([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct Float3GetZ : HHATZIKGBQL<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99FA9D0", Offset = "0x99F93D0", VA = "0x1899FA9D0")]
		public float KUNUVPUSRXA([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99FA9D0", Offset = "0x99F93D0", VA = "0x1899FA9D0", Slot = "4")]
		private float WIIBPKNSYVC([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct Int3GetX : HHATZIKGBQL<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x102A390", Offset = "0x1028D90", VA = "0x18102A390")]
		public int KUNUVPUSRXA([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x102A390", Offset = "0x1028D90", VA = "0x18102A390", Slot = "4")]
		private int IFVGOXOPMIJ([In] int3 value)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct Int3GetY : HHATZIKGBQL<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x13F83B0", Offset = "0x13F6DB0", VA = "0x1813F83B0")]
		public int KUNUVPUSRXA([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x13F83B0", Offset = "0x13F6DB0", VA = "0x1813F83B0", Slot = "4")]
		private int IFVGOXOPMIJ([In] int3 value)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Int3GetZ : HHATZIKGBQL<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xFBCCC0", Offset = "0xFBB6C0", VA = "0x180FBCCC0")]
		public int KUNUVPUSRXA([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xFBCCC0", Offset = "0xFBB6C0", VA = "0x180FBCCC0", Slot = "4")]
		private int IFVGOXOPMIJ([In] int3 value)
		{
			return default(int);
		}
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class RegisterComponentSystem : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B640", Offset = "0x2E5A040", VA = "0x182E5B640")]
		public RegisterComponentSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class ESSPNCTKZDM : SystemBase, SIYKGSMKJAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x99FA610", Offset = "0x99F9010", VA = "0x1899FA610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x395BDB0", Offset = "0x395A7B0", VA = "0x18395BDB0")]
		public void FKYZUQXNZGS<a>() where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x395BD20", Offset = "0x395A720", VA = "0x18395BD20")]
		public void EEKIAZVFUIN<b>() where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x395C0D0", Offset = "0x395AAD0", VA = "0x18395C0D0")]
		public JobHandle PGFZYFDEVEB<c>() where c : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x99FA790", Offset = "0x99F9190", VA = "0x1899FA790")]
		public JobHandle PGFZYFDEVEB(ReadOnlySpan<TypeIndex> a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x395C9C0", Offset = "0x395B3C0", VA = "0x18395C9C0")]
		public JobHandle ZAWYASAGDBQ<d>() where d : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99FA8D0", Offset = "0x99F92D0", VA = "0x1899FA8D0")]
		public JobHandle ZAWYASAGDBQ(ReadOnlySpan<TypeIndex> a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x395C2B0", Offset = "0x395ACB0", VA = "0x18395C2B0")]
		public void PWLIEBRIPJQ<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x395C1F0", Offset = "0x395ABF0", VA = "0x18395C1F0")]
		public JobHandle PWLIEBRIPJQ<f>(JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99FA7E0", Offset = "0x99F91E0", VA = "0x1899FA7E0")]
		public JobHandle PWLIEBRIPJQ(ReadOnlySpan<TypeIndex> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x395C5B0", Offset = "0x395AFB0", VA = "0x18395C5B0")]
		public void RDLGCAPLBVV<g>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x395C4F0", Offset = "0x395AEF0", VA = "0x18395C4F0")]
		public JobHandle RDLGCAPLBVV<h>(JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99FA850", Offset = "0x99F9250", VA = "0x1899FA850")]
		public JobHandle RDLGCAPLBVV(Span<TypeIndex> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x395C040", Offset = "0x395AA40", VA = "0x18395C040")]
		public ComponentDataFromEntity LNFSHURSTIZ<i>(bool a = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99FA640", Offset = "0x99F9040", VA = "0x1899FA640")]
		public ComponentDataFromEntity LNFSHURSTIZ(int a, bool b = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x395C850", Offset = "0x395B250", VA = "0x18395C850")]
		public SharedComponentIndexFromEntity<j> YCLOZHGVKLZ<j>() where j : ISharedComponentData
		{
			return default(SharedComponentIndexFromEntity<j>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99FA5B0", Offset = "0x99F8FB0", VA = "0x1899FA5B0")]
		[GenerateTestsForBurstCompatibility]
		public ComponentTypeHandle KNQYEECLJKZ(ComponentType a)
		{
			return default(ComponentTypeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99FA760", Offset = "0x99F9160", VA = "0x1899FA760")]
		public EntityExistenceLookupByEntity OFGWLSUXOQR()
		{
			return default(EntityExistenceLookupByEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99FA8C0", Offset = "0x99F92C0", VA = "0x1899FA8C0", Slot = "10")]
		public sealed override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x395BEF0", Offset = "0x395A8F0", VA = "0x18395BEF0")]
		public bool FQXONYSYETN<k>()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
		[Preserve]
		protected sealed override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B640", Offset = "0x2E5A040", VA = "0x182E5B640")]
		[Preserve]
		protected ESSPNCTKZDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class MUFCZINAJUD : ESSPNCTKZDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x99FAE20", Offset = "0x99F9820", VA = "0x1899FAE20", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2E5B640", Offset = "0x2E5A040", VA = "0x182E5B640")]
		[Preserve]
		protected MUFCZINAJUD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class NCKEPQUBLHY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class YIZOQFNDIML : EntityCommandBufferSystem, SIYKGSMKJAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Log YPBIFIZOQDI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD38DA0", Offset = "0xD377A0", VA = "0x180D38DA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x99FB7C0", Offset = "0x99FA1C0", VA = "0x1899FB7C0")]
		public YIZOQFNDIML(Log a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface HHATZIKGBQL<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b KUNUVPUSRXA([In] a value);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface TMQZGMIELAV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool EFLPAMKNLZD(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[BurstCompile]
	internal struct AddComponentECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ComponentTypeSet componentTypes;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99FA490", Offset = "0x99F8E90", VA = "0x1899FA490", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[BurstCompile]
	internal struct DestroyEntityECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x99FA510", Offset = "0x99F8F10", VA = "0x1899FA510", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[BurstCompile]
	internal struct RemoveComponentECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ComponentType componentType;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x99FB6A0", Offset = "0x99FA0A0", VA = "0x1899FB6A0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[BurstCompile]
	internal struct SetComponentECB<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x79AB9A0", Offset = "0x79AA3A0", VA = "0x1879AB9A0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal struct SetSharedComponentArrayECB<T> : IJob where T : struct, ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x79ACC60", Offset = "0x79AB660", VA = "0x1879ACC60", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal struct SetSharedComponentECB<T> : IJob where T : struct, ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Unity.Collections.ReadOnly]
		public T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x79ACE10", Offset = "0x79AB810", VA = "0x1879ACE10", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[BurstCompile]
	internal struct MapArrayJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HHATZIKGBQL<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[WriteOnly]
		public NativeArray<TTo> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FCED00", Offset = "0x6FCD700", VA = "0x186FCED00", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[BurstCompile]
	internal struct MapEntityToComponentDataArrayJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity srcDataFromEntity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[WriteOnly]
		public NativeArray<byte> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int typeSize;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99FAE50", Offset = "0x99F9850", VA = "0x1899FAE50", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[BurstCompile]
	internal struct MapEntityToComponentDataListJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> dstDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[WriteOnly]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF0E0", Offset = "0x6FCDAE0", VA = "0x186FCF0E0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BurstCompile]
	internal struct MapListJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HHATZIKGBQL<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[WriteOnly]
		public NativeList<TTo> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC530", Offset = "0x6FDAF30", VA = "0x186FDC530", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[BurstCompile]
	internal struct ReduceAllHaveComponentJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeArray<bool> dstResult;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x78E5570", Offset = "0x78E3F70", VA = "0x1878E5570", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct ReduceAnyHasComponentJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeArray<bool> dstResult;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x78E56F0", Offset = "0x78E40F0", VA = "0x1878E56F0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal struct ReduceDistinctJob<T> : IJob where T : struct, IEquatable<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeParallelHashSet<T> set;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x78E59E0", Offset = "0x78E43E0", VA = "0x1878E59E0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[BurstCompile]
	internal struct ReduceDistinctSelectJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : HHATZIKGBQL<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeList<TFrom> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeParallelHashSet<TTo> set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x78E5AA0", Offset = "0x78E44A0", VA = "0x1878E5AA0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	internal struct ReduceEntitiesPredicateJob<T, TPredicate> : IJob where T : struct where TPredicate : struct, TMQZGMIELAV<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntityArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeList<Entity> dstEntityList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TPredicate action;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x78E5F70", Offset = "0x78E4970", VA = "0x1878E5F70", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[BurstCompile]
	internal struct ReducePredicateJob<T, TPredicate> : IJob where T : struct where TPredicate : struct, TMQZGMIELAV<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TPredicate action;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x78E6860", Offset = "0x78E5260", VA = "0x1878E6860", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	internal struct ReduceWithComponentJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NativeList<Entity> dstEntities;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99FB570", Offset = "0x99F9F70", VA = "0x1899FB570", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[BurstCompile]
	internal struct ReduceWithoutComponentJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeList<Entity> dstEntities;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99FB600", Offset = "0x99FA000", VA = "0x1899FB600", Slot = "4")]
		[IgnoreWarning(1371)]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class YKBMKQVVYCQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class BKQAOFBCSWD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3725430", Offset = "0x3723E30", VA = "0x183725430")]
		public static bool OUKHGEMKQVV<T>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class FWRGBEBKTEV
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class BFMFCMZGCWC<a> where a : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public BFMFCMZGCWC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class OFNOLNZMEXZ<a> where a : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public OFNOLNZMEXZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly List<Func<JobHandle, JobHandle>> SGIDUWGATRS;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x99FA940", Offset = "0x99F9340", VA = "0x1899FA940")]
		public FWRGBEBKTEV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class QQKUTCHIYRV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class EIIBCGVJNEW
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct Array<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x2000038")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000052")]
				internal Array<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			internal NativeArray<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct List<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200003A")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				internal List<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal NativeList<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ArrayAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200003C")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				internal ArrayAsync<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal NativeArrayAsync<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public struct ListAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200003E")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				internal ListAsync<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal NativeListAsync<TFrom> src;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class UVWKUZTSDQE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class TOMLTXXJWGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3F516E0", Offset = "0x3F500E0", VA = "0x183F516E0")]
		public static NativeList<T> ZJDPRLUDYHW<T>(this NativeArray<T> a, Allocator b = Allocator.TempJob) where T : struct, IEquatable<T>
		{
			return default(NativeList<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class EKGUOKOEBJI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class MNZQGJAVOUW
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3C2FC30", Offset = "0x3C2E630", VA = "0x183C2FC30")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F440", Offset = "0x3C2DE40", VA = "0x183C2F440")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArrayAsync<Entity> entities, NativeArrayAsync<T> data, [Optional] JobHandle dependsOn) where T : struct, IComponentData
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F2E0", Offset = "0x3C2DCE0", VA = "0x183C2F2E0")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99FACC0", Offset = "0x99F96C0", VA = "0x1899FACC0")]
		[MustUseReturnValue]
		public static JobHandle AddComponent(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, ComponentTypeSet componentTypes, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99FAB50", Offset = "0x99F9550", VA = "0x1899FAB50")]
		[MustUseReturnValue]
		public static JobHandle AddComponent(this EntityCommandBufferSystem ecbs, EntityCommandBuffer ecb, NativeArray<Entity> entities, ComponentTypeSet componentTypes, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class TJULVBKGCBN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class QMUEHZFYLIT
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99FB2F0", Offset = "0x99F9CF0", VA = "0x1899FB2F0")]
		[MustUseReturnValue]
		public static JobHandle OVRPZTTHNCV(this EntityCommandBufferSystem a, NativeList<Entity> b, [Optional] JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99FB470", Offset = "0x99F9E70", VA = "0x1899FB470")]
		[MustUseReturnValue]
		public static JobHandle OVRPZTTHNCV(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class LGFPEPZCKQB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3C04A80", Offset = "0x3C03480", VA = "0x183C04A80")]
		public static void KGZJEQXUWOP<a>(this EntityCommandBufferSystem a, EntityQuery b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3C04C00", Offset = "0x3C03600", VA = "0x183C04C00")]
		[MustUseReturnValue]
		public static JobHandle RHWZLJMJHDB<e>(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b, [Optional] JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99FA9E0", Offset = "0x99F93E0", VA = "0x1899FA9E0")]
		[MustUseReturnValue]
		public static JobHandle RHWZLJMJHDB(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b, ComponentType c, [Optional] JobHandle d)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class DUETTIXHQXT
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x38FF3F0", Offset = "0x38FDDF0", VA = "0x1838FF3F0")]
		[MustUseReturnValue]
		public static JobHandle VKZCQXIUXAP<T>(this EntityCommandBufferSystem a, NativeArray<Entity> b, NativeArray<T> c, JobHandle d) where T : struct, IComponentData
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class PNVINHXJRAI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class RIFNQVEINAF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class NPKRAYTUHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EC90", Offset = "0x3D1D690", VA = "0x183D1EC90")]
		public static NativeArray<a> AGPKYCKACXS<a>(this NativeList<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where a : struct, IComponentData
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EAF0", Offset = "0x3D1D4F0", VA = "0x183D1EAF0")]
		public static NativeArray<b> AGPKYCKACXS<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where b : struct, IComponentData
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99FAF50", Offset = "0x99F9950", VA = "0x1899FAF50")]
		public static NativeArray<Entity> STBRLNTLYML(this NativeArray<Entity> a, EntityManager b, ComponentType c, Allocator d = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F630", Offset = "0x3D1E030", VA = "0x183D1F630")]
		public static NativeArray<T> SWVGZGFTWJJ<T>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class HFIQMJZOKXW
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct Array<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public Array<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public NativeArray<TFrom> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct ArrayAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200004E")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000061")]
				public ArrayAsync<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public NativeArrayAsync<TFrom> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct ListAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public ListAsync<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public NativeListAsync<TFrom> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class RYCSIKSFRGG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class VVSXWXJVSAY
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct RemapEntitiesAction : HHATZIKGBQL<Entity, Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[Unity.Collections.ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x99FB690", Offset = "0x99FA090", VA = "0x1899FB690")]
			[GenerateTestsForBurstCompatibility]
			public Entity KUNUVPUSRXA([In] Entity value)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x99FB690", Offset = "0x99FA090", VA = "0x1899FB690", Slot = "4")]
			private Entity YUSPGPSNHDN([In] Entity value)
			{
				return default(Entity);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class FIUXQUOYANV
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private struct Comparer<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x53CDA10", Offset = "0x53CC410", VA = "0x1853CDA10", Slot = "4")]
			public int Compare((TKey, TValue) x, (TKey, TValue) y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7FB0", Offset = "0x3AC69B0", VA = "0x183AC7FB0")]
		public static void Sort<TKey, TValue>(NativeList<TKey> keys, NativeList<TValue> values) where TKey : struct, IComparable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7DD0", Offset = "0x3AC67D0", VA = "0x183AC7DD0")]
		public static void Sort<TKey, TValue>(NativeArray<TKey> keys, NativeArray<TValue> values) where TKey : struct, IComparable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3AC96B0", Offset = "0x3AC80B0", VA = "0x183AC96B0")]
		public static void Sort<TKey, TValue, U>(NativeArray<TKey> keys, NativeArray<TValue> values, U comparer) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class VKSEXSAHIGZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct Array<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public NativeArray<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct List<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public NativeList<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct ArrayAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public NativeArrayAsync<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public NativeArrayAsync<T> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class MSEHZBIRYVL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class HEPIJCIVXYR
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public struct Array<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct List<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NativeList<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct ArrayAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public NativeArrayAsync<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct ListAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public NativeListAsync<T> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class JOWOQQCCBXT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class SJJHZLTEJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A490", Offset = "0x3F08E90", VA = "0x183F0A490")]
		public static NativeList<Entity> BFXKKYXMYZB<a>(this NativeList<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A170", Offset = "0x3F08B70", VA = "0x183F0A170")]
		public static NativeList<Entity> BFXKKYXMYZB<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class RFLIEAOVPSF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C010", Offset = "0x3E2AA10", VA = "0x183E2C010")]
		public static NativeList<Entity> YPJGKVHKXNB<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class IVWSUEUTZGS
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public readonly struct EnumerateHelper<TSrc> where TSrc : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public readonly struct SelectTypeEnumerateHelper<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public readonly struct SelectedTypeEnumerateHelper<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HHATZIKGBQL<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public struct SelectedTypeEnumerator<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, HHATZIKGBQL<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private readonly NativeArray<TSrc> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TSelector selector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int index;
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public struct GroupedSelectedTypeEnumerator<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HHATZIKGBQL<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private SelectedTypeEnumerator<TSrc, TValue, TSelector> enumerator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private TValue startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private int startIndex;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class OMKFXQBTYGR
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public struct GroupedEnumerator<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly NativeArray<T> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int startIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int currIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private T startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private T currValue;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public RecRoom.Foundation.Collections.Range AKSPFPWQXFQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x64D7FD0", Offset = "0x64D69D0", VA = "0x1864D7FD0")]
				get
				{
					return default(RecRoom.Foundation.Collections.Range);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public T PDKYIHZJKOC
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public (T, RecRoom.Foundation.Collections.Range) BSPHJBMXYAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x64D7DE0", Offset = "0x64D67E0", VA = "0x1864D7DE0")]
				get
				{
					return default((T, RecRoom.Foundation.Collections.Range));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x64D8B80", Offset = "0x64D7580", VA = "0x1864D8B80")]
			public GroupedEnumerator(NativeArray<T> array)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x543B0F0", Offset = "0x5439AF0", VA = "0x18543B0F0")]
			public GroupedEnumerator<T> GetEnumerator()
			{
				return default(GroupedEnumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x64D8990", Offset = "0x64D7390", VA = "0x1864D8990")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x39500B0", Offset = "0x394EAB0", VA = "0x1839500B0")]
			public GroupedWithComparerEnumerator<T, a> KEXZYKGZQCD<a>([Optional] a a) where a : struct, IEqualityComparer<T>
			{
				return default(GroupedWithComparerEnumerator<T, a>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct GroupedWithComparerEnumerator<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private readonly NativeArray<T> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int startIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private int currIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private T startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private T currValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TComparer comparer;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public RecRoom.Foundation.Collections.Range AKSPFPWQXFQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x64D7FD0", Offset = "0x64D69D0", VA = "0x1864D7FD0")]
				get
				{
					return default(RecRoom.Foundation.Collections.Range);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public T PDKYIHZJKOC
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public (T value, RecRoom.Foundation.Collections.Range range) BSPHJBMXYAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x64D91B0", Offset = "0x64D7BB0", VA = "0x1864D91B0")]
				get
				{
					return default((T, RecRoom.Foundation.Collections.Range));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x64D9B50", Offset = "0x64D8550", VA = "0x1864D9B50")]
			public GroupedWithComparerEnumerator(NativeArray<T> array, TComparer comparer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5451DB0", Offset = "0x54507B0", VA = "0x185451DB0")]
			public GroupedWithComparerEnumerator<T, TComparer> GetEnumerator()
			{
				return default(GroupedWithComparerEnumerator<T, TComparer>);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x64D9A70", Offset = "0x64D8470", VA = "0x1864D9A70")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3D55890", Offset = "0x3D54290", VA = "0x183D55890")]
		public static GroupedEnumerator<T> Group<T>(this NativeArray<T> array) where T : struct
		{
			return default(GroupedEnumerator<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct ProtobufMessageListDeserializer<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class NCANDMUWLZN : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private (int index, Protobuf element) AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public ProtobufMessageListDeserializer<Protobuf> AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private int OTWUEUFXKSW;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private (int, Protobuf) MWHRMFEBOLA
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x6631820", Offset = "0x6630220", VA = "0x186631820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default((int, Protobuf));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x66318D0", Offset = "0x66302D0", VA = "0x1866318D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x66319F0", Offset = "0x66303F0", VA = "0x1866319F0")]
			[DebuggerHidden]
			public NCANDMUWLZN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x71A0C30", Offset = "0x719F630", VA = "0x1871A0C30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x4EAEBC0", Offset = "0x4EAD5C0", VA = "0x184EAEBC0", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Action<Protobuf> resetToDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly CodedInputStream inputStream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Protobuf element;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x761CC40", Offset = "0x761B640", VA = "0x18761CC40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x761CA40", Offset = "0x761B440", VA = "0x18761CA40", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x761CAE0", Offset = "0x761B4E0", VA = "0x18761CAE0", Slot = "4")]
		[IteratorStateMachine(typeof(ProtobufMessageListDeserializer<>.NCANDMUWLZN))]
		public IEnumerator<(int, Protobuf)> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x761C9F0", Offset = "0x761B3F0", VA = "0x18761C9F0", Slot = "5")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct ProtobufMessageListSerializer<Protobuf> : IDisposable where Protobuf : IMessage, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly Protobuf element;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CodedOutputStream outputStream;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x761CC80", Offset = "0x761B680", VA = "0x18761CC80", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct ProtobufRawListDeserializer : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CodedInputStream inputStream;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x99FB190", Offset = "0x99F9B90", VA = "0x1899FB190", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct ProtobufRawListSerializer : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CodedOutputStream outputStream;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x99FB1D0", Offset = "0x99F9BD0", VA = "0x1899FB1D0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class YKESPKXKTSV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class MWHFUEAOLSY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[Flags]
	public enum RRWorldFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Live = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Editor = 3,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Main = 5,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Simulation = 9,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Conversion = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Staging = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Shadow = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Loading = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Saving = 0x100
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class CVMZQNZSWXX
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal class LVLAEJXDJHX
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1916790760
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x99FB7F0", Offset = "0x99FA1F0", VA = "0x1899FB7F0")]
	public static void BNIWUCRKOYO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x99FB8D0", Offset = "0x99FA2D0", VA = "0x1899FB8D0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
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
