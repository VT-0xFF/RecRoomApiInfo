using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D63A70", Offset = "0x7D62870", VA = "0x187D63A70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ELGLEAFEGHJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20D9420", Offset = "0x20D8220", VA = "0x1820D9420")]
	public ELGLEAFEGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, GHPGHPMCBFI, HMBFBKGPGPC, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash CHKEMFCNGMN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xBD1A10", Offset = "0xBD0810", VA = "0x180BD1A10")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[ReadOnlyField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D650D0", Offset = "0x7D63ED0", VA = "0x187D650D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D65090", Offset = "0x7D63E90", VA = "0x187D65090")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D65110", Offset = "0x7D63F10", VA = "0x187D65110")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D652C0", Offset = "0x7D640C0", VA = "0x187D652C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D65230", Offset = "0x7D64030", VA = "0x187D65230")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xF09910", Offset = "0xF08710", VA = "0x180F09910")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD6DF10", Offset = "0xD6CD10", VA = "0x180D6DF10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D65050", Offset = "0x7D63E50", VA = "0x187D65050")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D651A0", Offset = "0x7D63FA0", VA = "0x187D651A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D64AF0", Offset = "0x7D638F0", VA = "0x187D64AF0")]
	public void CopyBounds(SavedExtents HBLONCAMFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D64FA0", Offset = "0x7D63DA0", VA = "0x187D64FA0")]
	public void SetLocalSpaceBounds(Bounds GKBKECHABDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x147BCA0", Offset = "0x147AAA0", VA = "0x18147BCA0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D64F90", Offset = "0x7D63D90", VA = "0x187D64F90")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D64BE0", Offset = "0x7D639E0", VA = "0x187D64BE0")]
	private void MLCIECALCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D64D90", Offset = "0x7D63B90", VA = "0x187D64D90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D64480", Offset = "0x7D63280", VA = "0x187D64480")]
	public static void CalculateLocalBoundsFor(GameObject MMMAEDGEACA, [Out] Bounds GKBKECHABDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D64B20", Offset = "0x7D63920", VA = "0x187D64B20")]
	private static void HBIKGAGLFLJ(Bounds MDEAIGKHMKE, Color KMBJNMDOLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D64FC0", Offset = "0x7D63DC0", VA = "0x187D64FC0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x193BF80", Offset = "0x193AD80", VA = "0x18193BF80")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x59D0890", Offset = "0x59CF690", VA = "0x1859D0890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public virtual void NCPPPICKKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ELGLEAFEGHJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x59D0400", Offset = "0x59CF200", VA = "0x1859D0400", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x59CEFD0", Offset = "0x59CDDD0", VA = "0x1859CEFD0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x59D07B0", Offset = "0x59CF5B0", VA = "0x1859D07B0")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MOHNOIAEDMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MOHNOIAEDMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x53DB000", Offset = "0x53D9E00", VA = "0x1853DB000")]
		internal int PFDEDOFDLOC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[ELGLEAFEGHJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x461CBB0", Offset = "0x461B9B0", VA = "0x18461CBB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x461CC10", Offset = "0x461BA10", VA = "0x18461CC10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x461CA90", Offset = "0x461B890", VA = "0x18461CA90", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MAKJJJECHHB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x461CB50", Offset = "0x461B950", VA = "0x18461CB50", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x461C940", Offset = "0x461B740", VA = "0x18461C940", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x461C5E0", Offset = "0x461B3E0", VA = "0x18461C5E0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x461B9A0", Offset = "0x461A7A0", VA = "0x18461B9A0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x461B870", Offset = "0x461A670", VA = "0x18461B870", Slot = "14")]
	protected virtual string AGAILAPBHBJ(TKeyVal JJLFOGKKPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x461B8A0", Offset = "0x461A6A0", VA = "0x18461B8A0", Slot = "4")]
	public bool ContainsKey(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x461C7C0", Offset = "0x461B5C0", VA = "0x18461C7C0", Slot = "5")]
	public bool TryGetValue(TKey MAKJJJECHHB, [Out] TVal OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x461B900", Offset = "0x461A700", VA = "0x18461B900", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x461B900", Offset = "0x461A700", VA = "0x18461B900", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x461C820", Offset = "0x461B620", VA = "0x18461C820")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4592CE0", Offset = "0x4591AE0", VA = "0x184592CE0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[ELGLEAFEGHJ]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x59D2240", Offset = "0x59D1040", VA = "0x1859D2240")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x59D1A80", Offset = "0x59D0880", VA = "0x1859D1A80", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x59D1030", Offset = "0x59CFE30", VA = "0x1859D1030", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class OONGDMGFCGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct FKDDNHDEHIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T COJGBJGNJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float EDFHGDOADIH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int HDHCBHCPIPF = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float CMMPOGGPANB = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly FKDDNHDEHIB[] KNDCNOIHMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int PNFIEAHOEGD;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float MFMKPOGBACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC3C8E0", Offset = "0xC3B6E0", VA = "0x180C3C8E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC83370", Offset = "0xC82170", VA = "0x180C83370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T EOBHNEKFNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x56834C0", Offset = "0x56822C0", VA = "0x1856834C0")]
	protected OONGDMGFCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5683500", Offset = "0x5682300", VA = "0x185683500")]
	protected OONGDMGFCGE(int ACINDEOBNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x56831C0", Offset = "0x5681FC0", VA = "0x1856831C0")]
	public void AIKICPLLADB(float CKLBNPGGJHL, T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool NAMOFOIOKDM(float DKELFJONAAD, float PEAKBOBJENO, [Out] T OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool EIEEGAAILPG(float DKELFJONAAD, float PEAKBOBJENO, [Out] T OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5683450", Offset = "0x5682250", VA = "0x185683450")]
	public void CCLJDABAPHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PCEHNBBPHIN : OONGDMGFCGE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D63DA0", Offset = "0x7D62BA0", VA = "0x187D63DA0", Slot = "4")]
	public override bool NAMOFOIOKDM(float DKELFJONAAD, float PEAKBOBJENO, [Out] Vector3 OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D63C60", Offset = "0x7D62A60", VA = "0x187D63C60", Slot = "5")]
	public override bool EIEEGAAILPG(float DKELFJONAAD, float PEAKBOBJENO, [Out] Vector3 OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D63F00", Offset = "0x7D62D00", VA = "0x187D63F00")]
	public PCEHNBBPHIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LGDKKNPODMB
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39E9620", Offset = "0x39E8420", VA = "0x1839E9620")]
	public static NMADFLMJKJJ<T1, T2> BHEMCOAOOEF<T1, T2>(T1 BFNHNOFKALC, T2 GAODGJJOKGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x39E96C0", Offset = "0x39E84C0", VA = "0x1839E96C0")]
	public static AFHPOBCBEBB<T1, T2, T3> BHEMCOAOOEF<T1, T2, T3>(T1 BFNHNOFKALC, T2 GAODGJJOKGL, T3 IMNABHFFGDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5419400", Offset = "0x5418200", VA = "0x185419400")]
	internal static int BPIGINMDOHK(int PLEHBLAMFLC, int HICKMHFGLHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EB30", Offset = "0x6F4D930", VA = "0x186F4EB30")]
	internal static int BPIGINMDOHK(int PLEHBLAMFLC, int HICKMHFGLHG, int AGHCBLKGHED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NMADFLMJKJJ<T1, T2> : IComparable<NMADFLMJKJJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 PJKCFKOJGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 KMFDMBLCIDF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x54FDD90", Offset = "0x54FCB90", VA = "0x1854FDD90")]
	public NMADFLMJKJJ(T1 BFNHNOFKALC, T2 GAODGJJOKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x54FC3D0", Offset = "0x54FB1D0", VA = "0x1854FC3D0", Slot = "4")]
	public int CompareTo(NMADFLMJKJJ<T1, T2> HBLONCAMFLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x54FCBE0", Offset = "0x54FB9E0", VA = "0x1854FCBE0", Slot = "0")]
	public override bool Equals(object HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x54FD3A0", Offset = "0x54FC1A0", VA = "0x1854FD3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x54FD780", Offset = "0x54FC580", VA = "0x1854FD780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AFHPOBCBEBB<T1, T2, T3> : IComparable<AFHPOBCBEBB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 PJKCFKOJGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 KMFDMBLCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 APMJMILOMOC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8AD0", Offset = "0x4BA78D0", VA = "0x184BA8AD0")]
	public AFHPOBCBEBB(T1 BFNHNOFKALC, T2 GAODGJJOKGL, T3 IMNABHFFGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8160", Offset = "0x4BA6F60", VA = "0x184BA8160", Slot = "4")]
	public int CompareTo(AFHPOBCBEBB<T1, T2, T3> HBLONCAMFLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8410", Offset = "0x4BA7210", VA = "0x184BA8410", Slot = "0")]
	public override bool Equals(object HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4BA86E0", Offset = "0x4BA74E0", VA = "0x184BA86E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4BA8810", Offset = "0x4BA7610", VA = "0x184BA8810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve HKAKDFBMMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T ACNAAPHLKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x12E0300", Offset = "0x12DF100", VA = "0x1812E0300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T HPIANECPKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2C1A370", Offset = "0x2C19170", VA = "0x182C1A370")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2C1A380", Offset = "0x2C19180", VA = "0x182C1A380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float FGHHNEJDNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC27EC0", Offset = "0xC26CC0", VA = "0x180C27EC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5C9A180", Offset = "0x5C98F80", VA = "0x185C9A180")]
	public T EMACALLLFKJ(float JIJABGNNHPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5C9A680", Offset = "0x5C99480", VA = "0x185C9A680")]
	public T FPIPDOMLDGP(float JIJABGNNHPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LHOMADJAELM(T ALCLKCHJGII, T GFJPONDOIDH, float JIJABGNNHPJ);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7D618D0", Offset = "0x7D606D0", VA = "0x187D618D0", Slot = "4")]
	protected override float LHOMADJAELM(float ALCLKCHJGII, float GFJPONDOIDH, float JIJABGNNHPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D61910", Offset = "0x7D60710", VA = "0x187D61910")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x176CFF0", Offset = "0x176BDF0", VA = "0x18176CFF0", Slot = "4")]
	protected override Vector3 LHOMADJAELM(Vector3 ALCLKCHJGII, Vector3 GFJPONDOIDH, float JIJABGNNHPJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7D660E0", Offset = "0x7D64EE0", VA = "0x187D660E0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7D61140", Offset = "0x7D5FF40", VA = "0x187D61140", Slot = "4")]
	protected override Color LHOMADJAELM(Color ALCLKCHJGII, Color GFJPONDOIDH, float JIJABGNNHPJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7D61200", Offset = "0x7D60000", VA = "0x187D61200")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LPOCKIPKNNP : DDIMECLAJGG<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7D62660", Offset = "0x7D61460", VA = "0x187D62660")]
	public LPOCKIPKNNP(int KIOMCEJDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D625F0", Offset = "0x7D613F0", VA = "0x187D625F0", Slot = "6")]
	protected override uint NKCBJEINICA(uint CHKEMFCNGMN, string OAIIHELJHLG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FIPCLELCMAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable ICOFMPPJNFC;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public FIPCLELCMAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BFFLAHIOBEE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> JKBCFKAIGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int DPAMPLLFGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int IMJANCJKBOA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x541B5B0", Offset = "0x541A3B0", VA = "0x18541B5B0")]
	private BFFLAHIOBEE(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> LCJLHLPLBJJ, int KOAAOJJBLCL, int AEHODJLJACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60894B0", Offset = "0x60882B0", VA = "0x1860894B0")]
	public static BFFLAHIOBEE<T> NBEICDCLFEE()
	{
		return default(BFFLAHIOBEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60877B0", Offset = "0x60865B0", VA = "0x1860877B0")]
	public (int, int, Task<T>) LGBABEIPHNK(int FAPLIEIFOHC, [Optional] CancellationToken GHKBKDKNIOM, double POHFDNBLLPJ = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6088ED0", Offset = "0x6087CD0", VA = "0x186088ED0")]
	public void MCOCECNNLKG(int FAPLIEIFOHC, int AEHODJLJACF, [In] T BPINCJLADGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JLHNPFCMNNF
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7D62450", Offset = "0x7D61250", VA = "0x187D62450")]
	public static BFFLAHIOBEE<NICNPLCGCEF> NBEICDCLFEE()
	{
		return default(BFFLAHIOBEE<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7D623D0", Offset = "0x7D611D0", VA = "0x187D623D0")]
	public static void MCOCECNNLKG([In] this BFFLAHIOBEE<NICNPLCGCEF> FPFHIDBMBMI, int FAPLIEIFOHC, int AEHODJLJACF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class HEJFBAJPMNN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> AGFHJJIHADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> FBKACNHFHAB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x41B40C0", Offset = "0x41B2EC0", VA = "0x1841B40C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LHOLHNBADAD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> FJHHIONJFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x45F7E10", Offset = "0x45F6C10", VA = "0x1845F7E10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> HFKBMCLKGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4C1DC80", Offset = "0x4C1CA80", VA = "0x184C1DC80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4C1DC20", Offset = "0x4C1CA20", VA = "0x184C1DC20", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4C1DD10", Offset = "0x4C1CB10", VA = "0x184C1DD10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4C1D560", Offset = "0x4C1C360", VA = "0x184C1D560")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D1B0", Offset = "0x4C1BFB0", VA = "0x184C1D1B0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4C1DA50", Offset = "0x4C1C850", VA = "0x184C1DA50", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4C1CF30", Offset = "0x4C1BD30", VA = "0x184C1CF30", Slot = "9")]
	public void Add(TKey MAKJJJECHHB, TVal OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4C1CEE0", Offset = "0x4C1BCE0", VA = "0x184C1CEE0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D250", Offset = "0x4C1C050", VA = "0x184C1D250", Slot = "8")]
	public bool ContainsKey(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D2E0", Offset = "0x4C1C0E0", VA = "0x184C1D2E0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D940", Offset = "0x4C1C740", VA = "0x184C1D940", Slot = "10")]
	public bool Remove(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D9C0", Offset = "0x4C1C7C0", VA = "0x184C1D9C0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4C1DAA0", Offset = "0x4C1C8A0", VA = "0x184C1DAA0", Slot = "11")]
	public bool TryGetValue(TKey MAKJJJECHHB, [Out] TVal OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D460", Offset = "0x4C1C260", VA = "0x184C1D460", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D320", Offset = "0x4C1C120", VA = "0x184C1D320", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KNDCNOIHMGO, int PIJHOBEHDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D400", Offset = "0x4C1C200", VA = "0x184C1D400")]
	public bool GNFCCDJDLII(TVal MAKJJJECHHB, [Out] TKey OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D780", Offset = "0x4C1C580", VA = "0x184C1D780")]
	private void NCEHAEBIJDM(TKey MAKJJJECHHB, TVal AFBDJBIOHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D690", Offset = "0x4C1C490", VA = "0x184C1D690")]
	private void IALCIBOMKCK(TKey MAKJJJECHHB, TVal AFBDJBIOHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4C1D090", Offset = "0x4C1BE90", VA = "0x184C1D090")]
	private bool CJBGJMGELEG(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4C1DB00", Offset = "0x4C1C900", VA = "0x184C1DB00")]
	public HEJFBAJPMNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class LLLPPDPKBDD<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private LLLPPDPKBDD<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4672840", Offset = "0x4671640", VA = "0x184672840", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4689110", Offset = "0x4687F10", VA = "0x184689110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4689D90", Offset = "0x4688B90", VA = "0x184689D90")]
		public Enumerator(LLLPPDPKBDD<T> GLBDCBGACGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x46871B0", Offset = "0x4685FB0", VA = "0x1846871B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4688120", Offset = "0x4686F20", VA = "0x184688120", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4686670", Offset = "0x4685470", VA = "0x184686670")]
		private void HFBLJKPBMGJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] AKAPGMCKHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int AJOJFAFFHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int PBECAFEFCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int MFIBIFPFGCD;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x51A7F70", Offset = "0x51A6D70", VA = "0x1851A7F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x51A8B70", Offset = "0x51A7970", VA = "0x1851A8B70")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x51A8AC0", Offset = "0x51A78C0", VA = "0x1851A8AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x51A9B10", Offset = "0x51A8910", VA = "0x1851A9B10")]
	public LLLPPDPKBDD(int KIOMCEJDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x51A7980", Offset = "0x51A6780", VA = "0x1851A7980")]
	public void AIKICPLLADB(T JIJABGNNHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x51A7FE0", Offset = "0x51A6DE0", VA = "0x1851A7FE0")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x51A8720", Offset = "0x51A7520", VA = "0x1851A8720")]
	public void FLDEJOBHCNA(int ALFGNAHPKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x51A8FF0", Offset = "0x51A7DF0", VA = "0x1851A8FF0")]
	public void JCJPJJOOLPO(T[] KNDCNOIHMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x51A9790", Offset = "0x51A8590", VA = "0x1851A9790")]
	public Enumerator PHEMDOOJNPF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x51A98B0", Offset = "0x51A86B0", VA = "0x1851A98B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x51A98B0", Offset = "0x51A86B0", VA = "0x1851A98B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x51A8130", Offset = "0x51A6F30", VA = "0x1851A8130")]
	private int EJDEHGBIAPH(int GLAOLHCPLLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x51A7FB0", Offset = "0x51A6DB0", VA = "0x1851A7FB0")]
	private int BILAENJBJAA(int GLAOLHCPLLG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NBMBIHHMOFK<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> MDKAIAJEPGN(TRequest OHDJLNAKLPC, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum NNIAAJHCKHE
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NJIDPKFEPBC
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float BGNBHBKNLGK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan DFNOIMMAHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int IDEHPCENOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NNIAAJHCKHE JMDPPCOELCD;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly NJIDPKFEPBC OOIHKAJEMOK;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float PNMKECPEHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x54C79E0", Offset = "0x54C67E0", VA = "0x1854C79E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan MAEFNGEMOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x54C7B30", Offset = "0x54C6930", VA = "0x1854C7B30")]
		public NJIDPKFEPBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct HNBFFEDCPOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest OHDJLNAKLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken GHKBKDKNIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> BOKOJFIAMEK;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4C54DA0", Offset = "0x4C53BA0", VA = "0x184C54DA0")]
		public HNBFFEDCPOB(TRequest OHDJLNAKLPC, TaskCompletionSource<TResult> BOKOJFIAMEK, CancellationToken GHKBKDKNIOM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct OOAOHFHFCJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NBMBIHHMOFK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5681650", Offset = "0x5680450", VA = "0x185681650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5681E50", Offset = "0x5680C50", VA = "0x185681E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct HLCHLGPIDJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NBMBIHHMOFK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private HNBFFEDCPOB <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4C452A0", Offset = "0x4C440A0", VA = "0x184C452A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4C45940", Offset = "0x4C44740", VA = "0x184C45940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource KEGNLGKOMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<HNBFFEDCPOB> DAMPHEIKNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NJIDPKFEPBC CENOLPKAGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MDKAIAJEPGN BHCFGLGIPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task LLMKMCGCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int HOBDMONKCGL;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x546F860", Offset = "0x546E660", VA = "0x18546F860")]
	public NBMBIHHMOFK(MDKAIAJEPGN BHCFGLGIPFE, [Optional] NJIDPKFEPBC CENOLPKAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x546F4B0", Offset = "0x546E2B0", VA = "0x18546F4B0")]
	public Task<TResult> MLIIOBDPLBG(TRequest OHDJLNAKLPC, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x546F160", Offset = "0x546DF60", VA = "0x18546F160")]
	private void KIPCIMMGFOO(HNBFFEDCPOB NIGEILLNOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x546EAF0", Offset = "0x546D8F0", VA = "0x18546EAF0")]
	[AsyncStateMachine(typeof(NBMBIHHMOFK<, >.OOAOHFHFCJF))]
	private Task INLJPPMNLPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x546E7E0", Offset = "0x546D5E0", VA = "0x18546E7E0")]
	private HNBFFEDCPOB AOMFLEPMMEM()
	{
		return default(HNBFFEDCPOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x546EF90", Offset = "0x546DD90", VA = "0x18546EF90")]
	[AsyncStateMachine(typeof(NBMBIHHMOFK<, >.HLCHLGPIDJE))]
	private Task KEJOAMCPKNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x546ED90", Offset = "0x546DB90", VA = "0x18546ED90")]
	private void JAMEFGGIOIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x546EAB0", Offset = "0x546D8B0", VA = "0x18546EAB0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class KAEOPIMMHLK<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> COKPAJOONAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> FLCKENDDLAI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x41B40C0", Offset = "0x41B2EC0", VA = "0x1841B40C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool LHOLHNBADAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3A70B80", Offset = "0x3A6F980", VA = "0x183A70B80", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x508EA40", Offset = "0x508D840", VA = "0x18508EA40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4AF7830", Offset = "0x4AF6630", VA = "0x184AF7830", Slot = "11")]
	public void Add(T HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x508E400", Offset = "0x508D200", VA = "0x18508E400")]
	public bool PBGCPDIDMGE(T HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x508E860", Offset = "0x508D660", VA = "0x18508E860", Slot = "15")]
	public bool Remove(T HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A61ED0", Offset = "0x4A60CD0", VA = "0x184A61ED0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4B41A80", Offset = "0x4B40880", VA = "0x184B41A80", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x508DF20", Offset = "0x508CD20", VA = "0x18508DF20", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x508DFC0", Offset = "0x508CDC0", VA = "0x18508DFC0", Slot = "13")]
	public bool Contains(T HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x508E010", Offset = "0x508CE10", VA = "0x18508E010", Slot = "14")]
	public void CopyTo(T[] KNDCNOIHMGO, int PIJHOBEHDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC060", Offset = "0x4BDAE60", VA = "0x184BDC060", Slot = "6")]
	public int IndexOf(T HHHFHHLBBIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x508E1C0", Offset = "0x508CFC0", VA = "0x18508E1C0", Slot = "7")]
	public void Insert(int GLAOLHCPLLG, T HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x508E650", Offset = "0x508D450", VA = "0x18508E650", Slot = "8")]
	public void RemoveAt(int GLAOLHCPLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x508E920", Offset = "0x508D720", VA = "0x18508E920")]
	public KAEOPIMMHLK()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2A6A150", Offset = "0x2A68F50", VA = "0x182A6A150")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2556D50", Offset = "0x2555B50", VA = "0x182556D50")]
		public SerializedGuid([In] Guid PDFBNFKDLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D65350", Offset = "0x7D64150", VA = "0x187D65350")]
		public static SerializedGuid CNBGDJJKGGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D65540", Offset = "0x7D64340", VA = "0x187D65540")]
		public static SerializedGuid OMKONKIPLMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D65400", Offset = "0x7D64200", VA = "0x187D65400")]
		public bool DAEKNHIBCFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D65630", Offset = "0x7D64430", VA = "0x187D65630", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D655B0", Offset = "0x7D643B0", VA = "0x187D655B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D65460", Offset = "0x7D64260", VA = "0x187D65460", Slot = "7")]
		public bool Equals(SerializedGuid HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D654A0", Offset = "0x7D642A0", VA = "0x187D654A0", Slot = "0")]
		public override bool Equals(object GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D65530", Offset = "0x7D64330", VA = "0x187D65530", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D653D0", Offset = "0x7D641D0", VA = "0x187D653D0", Slot = "6")]
		public int CompareTo(SerializedGuid HBLONCAMFLG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JIAMEILEPGD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type HJMMACFMBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string KJEODGCGPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool EEAAGEKMPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool KNEEAPDCAGM;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D62360", Offset = "0x7D61160", VA = "0x187D62360")]
	public JIAMEILEPGD(Type NFDHDNNGJHN, string OFPEMDHJHPC, bool JPCMIEFJDHP = false, bool HCDEHDFCGJL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NMGNFBJCCPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int PDCOLAGFGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> OIAJIPBDHFK(float CKLBNPGGJHL, [Optional] float? GHILJJACEIL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JEBOEJDPPFF(float CKLBNPGGJHL, T OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCLJDABAPHP();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class BBBOCMFGPLC<T> : NMGNFBJCCPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class EPHCLDOBIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float GJBBGPENBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T COJGBJGNJFM;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EPHCLDOBIGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MGNKIDBCBOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MGNKIDBCBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x53BBD70", Offset = "0x53BAB70", VA = "0x1853BBD70")]
		internal bool ANEMNAKKFCA(EPHCLDOBIGE sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float KJDMHBAJFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float LBPPPNEGJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<EPHCLDOBIGE> KJIPGHKINFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private JJHFHBONIDO<EPHCLDOBIGE> GEKELBKLKLK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int PDCOLAGFGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5FF9F30", Offset = "0x5FF8D30", VA = "0x185FF9F30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA680", Offset = "0x5FF9480", VA = "0x185FFA680")]
	public BBBOCMFGPLC(float NFKFKEMKIJI, float ENLDPJJLGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9B40", Offset = "0x5FF8940", VA = "0x185FF9B40", Slot = "6")]
	public bool JEBOEJDPPFF(float CKLBNPGGJHL, T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9FA0", Offset = "0x5FF8DA0", VA = "0x185FF9FA0", Slot = "5")]
	public IEnumerable<T> OIAJIPBDHFK(float CKLBNPGGJHL, float? GHILJJACEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5FF98D0", Offset = "0x5FF86D0", VA = "0x185FF98D0", Slot = "7")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9D10", Offset = "0x5FF8B10", VA = "0x185FF9D10")]
	private void KPLHKJODDHM(float CKLBNPGGJHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class AHJAGGOINHD<T> : NMGNFBJCCPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct BBJDCOBOHGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T COJGBJGNJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float GJBBGPENBMJ;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5142AA0", Offset = "0x51418A0", VA = "0x185142AA0")]
		public BBJDCOBOHGL(T OAIIHELJHLG, float CKLBNPGGJHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FILKIDMOAKA : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AHJAGGOINHD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public FILKIDMOAKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4ACED90", Offset = "0x4ACDB90", VA = "0x184ACED90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4ACF160", Offset = "0x4ACDF60", VA = "0x184ACF160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4ACF040", Offset = "0x4ACDE40", VA = "0x184ACF040", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4ACF120", Offset = "0x4ACDF20", VA = "0x184ACF120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float NFKFKEMKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float ENLDPJJLGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<BBJDCOBOHGL> KJIPGHKINFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int AJOJFAFFHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int EPAALKHKFKI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int PDCOLAGFGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4DBE970", Offset = "0x4DBD770", VA = "0x184DBE970")]
	public AHJAGGOINHD(float NFKFKEMKIJI, float ENLDPJJLGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4DBDEC0", Offset = "0x4DBCCC0", VA = "0x184DBDEC0", Slot = "6")]
	public bool JEBOEJDPPFF(float CKLBNPGGJHL, T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4DBDE70", Offset = "0x4DBCC70", VA = "0x184DBDE70", Slot = "8")]
	public int IIIAIBJFBFG(float CKLBNPGGJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4DBE680", Offset = "0x4DBD480", VA = "0x184DBE680", Slot = "5")]
	[IteratorStateMachine(typeof(AHJAGGOINHD<>.FILKIDMOAKA))]
	public IEnumerable<T> OIAJIPBDHFK(float CKLBNPGGJHL, float? GHILJJACEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4DBDC30", Offset = "0x4DBCA30", VA = "0x184DBDC30", Slot = "7")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4DBDD80", Offset = "0x4DBCB80", VA = "0x184DBDD80")]
	private void HPFCBDLBNLD(float CKLBNPGGJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4DBE4F0", Offset = "0x4DBD2F0", VA = "0x184DBE4F0")]
	private BBJDCOBOHGL OHLMKHDBFOI()
	{
		return default(BBJDCOBOHGL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class HBCKFDINPOH<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct HLJLHOOIEBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long DLBAONGCIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long KNHMHBGINNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int BAIENDEILND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int LGCDMCCKFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool ECIIBBFHKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string LAJHALLNIPG;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4C45D80", Offset = "0x4C44B80", VA = "0x184C45D80")]
		public HLJLHOOIEBP(long DLBAONGCIHO, int BAIENDEILND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4C45D50", Offset = "0x4C44B50", VA = "0x184C45D50")]
		public HLJLHOOIEBP(long DLBAONGCIHO, long KNHMHBGINNB, int BAIENDEILND, int LGCDMCCKFNL, bool ECIIBBFHKKH, string LAJHALLNIPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4C45BE0", Offset = "0x4C449E0", VA = "0x184C45BE0")]
		public int ENNCLHCKCNH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4C45C30", Offset = "0x4C44A30", VA = "0x184C45C30")]
		public int FFEKMPDIDPP(int KPLCAKDPJHO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4C45C50", Offset = "0x4C44A50", VA = "0x184C45C50")]
		public double IEAMAKOJJMM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4C45CB0", Offset = "0x4C44AB0", VA = "0x184C45CB0")]
		public HLJLHOOIEBP JJKAJGOGPHP(long KNHMHBGINNB, int LGCDMCCKFNL)
		{
			return default(HLJLHOOIEBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class DLKHFLDLCIN : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct HPLGGJFNGJK<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public DLKHFLDLCIN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<DLKHFLDLCIN, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private DLKHFLDLCIN <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4C5A000", Offset = "0x4C58E00", VA = "0x184C5A000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x45E18E0", Offset = "0x45E06E0", VA = "0x1845E18E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey IKLJNBNIMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly HBCKFDINPOH<TKey> HMLAIBMJFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly IEBEPMGFCGH NHLEILEPJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<DLKHFLDLCIN> CGEONFPNALE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string BNFCEDMBAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4F6AD00", Offset = "0x4F69B00", VA = "0x184F6AD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<DLKHFLDLCIN> HDOMAGFGOJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6B201E0", Offset = "0x6B1EFE0", VA = "0x186B201E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public HLJLHOOIEBP JNDLJOKDLAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6B20220", Offset = "0x6B1F020", VA = "0x186B20220")]
			[CompilerGenerated]
			get
			{
				return default(HLJLHOOIEBP);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6B20490", Offset = "0x6B1F290", VA = "0x186B20490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6B20670", Offset = "0x6B1F470", VA = "0x186B20670")]
		internal DLKHFLDLCIN(HBCKFDINPOH<TKey> HMLAIBMJFEO, TKey MAKJJJECHHB, IEBEPMGFCGH NHLEILEPJMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6B204C0", Offset = "0x6B1F2C0", VA = "0x186B204C0")]
		public DLKHFLDLCIN IODDGFJAGAA(TKey MAKJJJECHHB, [Optional] IEBEPMGFCGH? FMGEBOJFCEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3A71E50", Offset = "0x3A70C50", VA = "0x183A71E50")]
		[AsyncStateMachine(typeof(HPLGGJFNGJK<>))]
		public Task<T> PGOLKBNGLGC<T>(TKey MAKJJJECHHB, Func<DLKHFLDLCIN, Task<T>> HPCIBKDHMEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6B20240", Offset = "0x6B1F040", VA = "0x186B20240", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JDPOKFIFKFB : IEnumerable<(TKey, List<TKey>, HLJLHOOIEBP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HLJLHOOIEBP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, HLJLHOOIEBP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public HBCKFDINPOH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, HLJLHOOIEBP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, HLJLHOOIEBP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2A60EF0", Offset = "0x2A5FCF0", VA = "0x182A60EF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HLJLHOOIEBP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4F80B30", Offset = "0x4F7F930", VA = "0x184F80B30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2A60FE0", Offset = "0x2A5FDE0", VA = "0x182A60FE0")]
		[DebuggerHidden]
		public JDPOKFIFKFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4AD3700", Offset = "0x4AD2500", VA = "0x184AD3700", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4F80620", Offset = "0x4F7F420", VA = "0x184F80620", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4F809C0", Offset = "0x4F7F7C0", VA = "0x184F809C0")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4F80AE0", Offset = "0x4F7F8E0", VA = "0x184F80AE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4F80A10", Offset = "0x4F7F810", VA = "0x184F80A10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HLJLHOOIEBP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4B1D840", Offset = "0x4B1C640", VA = "0x184B1D840", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class HBAMJLPKIEH : IEnumerable<(TKey, List<TKey>, HLJLHOOIEBP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HLJLHOOIEBP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, HLJLHOOIEBP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private DLKHFLDLCIN timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public DLKHFLDLCIN <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HBCKFDINPOH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<DLKHFLDLCIN> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, HLJLHOOIEBP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, HLJLHOOIEBP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2A60EF0", Offset = "0x2A5FCF0", VA = "0x182A60EF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HLJLHOOIEBP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4C15010", Offset = "0x4C13E10", VA = "0x184C15010", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2A60FE0", Offset = "0x2A5FDE0", VA = "0x182A60FE0")]
		[DebuggerHidden]
		public HBAMJLPKIEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4C15070", Offset = "0x4C13E70", VA = "0x184C15070", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4C14650", Offset = "0x4C13450", VA = "0x184C14650", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4C14E20", Offset = "0x4C13C20", VA = "0x184C14E20")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4C145F0", Offset = "0x4C133F0", VA = "0x184C145F0")]
		private void IMLDEFFNBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4C14FC0", Offset = "0x4C13DC0", VA = "0x184C14FC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4C14E80", Offset = "0x4C13C80", VA = "0x184C14E80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HLJLHOOIEBP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4C14F80", Offset = "0x4C13D80", VA = "0x184C14F80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, HLJLHOOIEBP, IEBEPMGFCGH> EMIIKDENJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, HLJLHOOIEBP, IEBEPMGFCGH> EALJJKEJIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<HBCKFDINPOH<TKey>, IEBEPMGFCGH> OINIIANMNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly DLKHFLDLCIN HAPFNAJINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool OMPJCPABCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int PLEGKDNOCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch JMGNKGLHNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int OPHOMMBBBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string LEDMOHLDHAD;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public DLKHFLDLCIN MAPDFKJJMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string BNFCEDMBAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4C151F0", Offset = "0x4C13FF0", VA = "0x184C151F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4C15520", Offset = "0x4C14320", VA = "0x184C15520")]
	public HBCKFDINPOH(TKey BODGDJPFMFB, IEBEPMGFCGH NHLEILEPJMB, [Optional] int? BAIENDEILND, [Optional][CanBeNull] Stopwatch JMGNKGLHNDI, [Optional] Action<TKey, HLJLHOOIEBP, IEBEPMGFCGH> EMIIKDENJCN, [Optional] Action<TKey, HLJLHOOIEBP, IEBEPMGFCGH> EALJJKEJIKN, [Optional] Action<HBCKFDINPOH<TKey>, IEBEPMGFCGH> OINIIANMNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4C15250", Offset = "0x4C14050", VA = "0x184C15250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4C15480", Offset = "0x4C14280", VA = "0x184C15480")]
	[IteratorStateMachine(typeof(HBCKFDINPOH<>.JDPOKFIFKFB))]
	public IEnumerable<(TKey, List<TKey>, HLJLHOOIEBP)> PDOENJGHLAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C153A0", Offset = "0x4C141A0", VA = "0x184C153A0")]
	[IteratorStateMachine(typeof(HBCKFDINPOH<>.HBAMJLPKIEH))]
	private IEnumerable<(TKey, List<TKey>, HLJLHOOIEBP)> PDOENJGHLAJ(List<TKey> NOBPJADLJBL, DLKHFLDLCIN FFINBNFCEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4C15320", Offset = "0x4C14120", VA = "0x184C15320")]
	private (long, int) OFNEFKLMKAF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class CAEHHGGDIMK<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KICDBONCGLN(HBCKFDINPOH<TKey> HMLAIBMJFEO);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected CAEHHGGDIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class LIIGFOBBPFD<TKey> : CAEHHGGDIMK<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string GFPNCBEBPDC(TKey MAKJJJECHHB);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5195450", Offset = "0x5194250", VA = "0x185195450")]
	private static string IKKMPPIGCOB(TKey MAKJJJECHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5195490", Offset = "0x5194290", VA = "0x185195490", Slot = "4")]
	public override string KICDBONCGLN(HBCKFDINPOH<TKey> HMLAIBMJFEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5195570", Offset = "0x5194370", VA = "0x185195570")]
	public string KICDBONCGLN(HBCKFDINPOH<TKey> HMLAIBMJFEO, [NotNull] GFPNCBEBPDC GONAFPBCCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string AOPBODOBPJG(HBCKFDINPOH<TKey> HMLAIBMJFEO, [NotNull] GFPNCBEBPDC GONAFPBCCLG);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F990", Offset = "0x4C8E790", VA = "0x184C8F990")]
	protected LIIGFOBBPFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class LJHAKMDNPCA<TKey> : CAEHHGGDIMK<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string HKGEHOODHAB(TKey MAKJJJECHHB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string MEHGKABNENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double DFIPPFEMADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool PEMJOIDLGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int EINMPHEFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> PDENOAGHCFC;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x51989E0", Offset = "0x51977E0", VA = "0x1851989E0")]
	private static string IKKMPPIGCOB(TKey MAKJJJECHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x51995F0", Offset = "0x51983F0", VA = "0x1851995F0")]
	public LJHAKMDNPCA(string MEHGKABNENG = "F2", double DFIPPFEMADC = double.MaxValue, bool PEMJOIDLGKE = false, int EINMPHEFMNN = int.MaxValue, [Optional] ISet<string> PDENOAGHCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x51991C0", Offset = "0x5197FC0", VA = "0x1851991C0", Slot = "4")]
	public override Dictionary<string, string> KICDBONCGLN(HBCKFDINPOH<TKey> HMLAIBMJFEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5199510", Offset = "0x5198310", VA = "0x185199510")]
	private bool OLKCEHBCNOC(string CDJANOPKLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5198B80", Offset = "0x5197980", VA = "0x185198B80")]
	public Dictionary<string, string> KICDBONCGLN(HBCKFDINPOH<TKey> HMLAIBMJFEO, HKGEHOODHAB GONAFPBCCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x51992A0", Offset = "0x51980A0", VA = "0x1851992A0")]
	private string OLDJKHGIGEP(StringBuilder AOILPLJNIKA, List<TKey> NJKAIMCENJB, HKGEHOODHAB GONAFPBCCLG, bool DDFHOJOJCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5198A20", Offset = "0x5197820", VA = "0x185198A20")]
	private static void KHMJDMBNCEM(StringBuilder ADDBANDFCEI, string LODKDLFAAPH, bool AKDKCGJFINI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class POPPFIHPCKE<TKey> : LIIGFOBBPFD<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct OFFLABJHJMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GFPNCBEBPDC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static POPPFIHPCKE<TKey> ICOFMPPJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] CGELNEBELGN;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x57BF360", Offset = "0x57BE160", VA = "0x1857BF360")]
	private POPPFIHPCKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x57BE300", Offset = "0x57BD100", VA = "0x1857BE300", Slot = "5")]
	protected override string AOPBODOBPJG(HBCKFDINPOH<TKey> HMLAIBMJFEO, GFPNCBEBPDC GONAFPBCCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x57BF120", Offset = "0x57BDF20", VA = "0x1857BF120")]
	[CompilerGenerated]
	internal static string FFBILGKACND(string FAHAEILOKIF, TKey MAKJJJECHHB, OFFLABJHJMC P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class DPPALPOPMKA : HBCKFDINPOH<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class NEELDKLHAGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<DPPALPOPMKA, IEBEPMGFCGH> callback;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NEELDKLHAGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7D639E0", Offset = "0x7D627E0", VA = "0x187D639E0")]
		internal void IJOJLLBPMCM(HBCKFDINPOH<string> timer, IEBEPMGFCGH log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7D61640", Offset = "0x7D60440", VA = "0x187D61640")]
	public DPPALPOPMKA(IEBEPMGFCGH NHLEILEPJMB, [Optional] string PLLKLGIGJPP, [Optional] int? BAIENDEILND, [Optional] Stopwatch JMGNKGLHNDI, [Optional] Action<string, HLJLHOOIEBP, IEBEPMGFCGH> EMIIKDENJCN, [Optional] Action<string, HLJLHOOIEBP, IEBEPMGFCGH> EALJJKEJIKN, [Optional] Action<DPPALPOPMKA, IEBEPMGFCGH> OINIIANMNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7D61580", Offset = "0x7D60380", VA = "0x187D61580")]
	private static Action<HBCKFDINPOH<string>, IEBEPMGFCGH> CCJDAPJKELF(Action<DPPALPOPMKA, IEBEPMGFCGH> LDLIMOGOGBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class PAJMBCMBIBB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class MPPAEINDODA : PAJMBCMBIBB
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static PAJMBCMBIBB ICOFMPPJNFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7D626B0", Offset = "0x7D614B0", VA = "0x187D626B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float KAFLEPPNKIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x1240C70", Offset = "0x123FA70", VA = "0x181240C70", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7D627B0", Offset = "0x7D615B0", VA = "0x187D627B0")]
		public MPPAEINDODA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static PAJMBCMBIBB AADBOBLODOM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static PAJMBCMBIBB OOIHKAJEMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7D63AF0", Offset = "0x7D628F0", VA = "0x187D63AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float KAFLEPPNKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected PAJMBCMBIBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface EPIKNCDFKGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool PIFBNBODPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface EHIFMMNJMNN<T> : EPIKNCDFKGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> AMOBKEDPMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	HMBEFKLHMDK<T> APMAEOAMGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class KONKHEHICKO
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x39E22B0", Offset = "0x39E10B0", VA = "0x1839E22B0")]
	public static EHIFMMNJMNN<TResource> LDALBAELIPE<TResource, TId>(this GCCFCBBMFKB<TId, TResource> EHNDDIAIEKC, TId FONJFDCCINO, [Optional] Func<TId, CancellationToken, Task<TResource>>? KBMOEEAIBCF) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class OJGGOGBHMJH
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class IGAMMIFPPFA<T> : AHEBAANNNJJ<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> AMOBKEDPMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override HMBEFKLHMDK<T?> APMAEOAMGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x4D33D70", Offset = "0x4D32B70", VA = "0x184D33D70")]
		public IGAMMIFPPFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "10")]
		protected override void LPJFLBHHFLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class PFKCLKMACLA<T> : AHEBAANNNJJ<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T MBGJGLGBJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? OMHEKKOGFMM;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> AMOBKEDPMBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override HMBEFKLHMDK<T> APMAEOAMGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5775F20", Offset = "0x5774D20", VA = "0x185775F20")]
		public PFKCLKMACLA(T OFDGCGBJAJI, Action<T>? JDNGNIOHEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5775D30", Offset = "0x5774B30", VA = "0x185775D30", Slot = "10")]
		protected override void LPJFLBHHFLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class LGCOMBGMBPG<T> : AHEBAANNNJJ<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> AMOBKEDPMBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override HMBEFKLHMDK<T> APMAEOAMGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x515F240", Offset = "0x515E040", VA = "0x18515F240")]
		public LGCOMBGMBPG(Exception ANMGGEBBMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "10")]
		protected override void LPJFLBHHFLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class MLMFBBEKADL<T> : AHEBAANNNJJ<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct JJOEIGGOCGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<EHIFMMNJMNN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<EHIFMMNJMNN<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4FC1B00", Offset = "0x4FC0900", VA = "0x184FC1B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4FC24E0", Offset = "0x4FC12E0", VA = "0x184FC24E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct FJLFCNMGJPA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<EHIFMMNJMNN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<EHIFMMNJMNN<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1170", Offset = "0x4ACFF70", VA = "0x184AD1170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1400", Offset = "0x4AD0200", VA = "0x184AD1400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<EHIFMMNJMNN<T>> FGBPDHOCDNL;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> AMOBKEDPMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override HMBEFKLHMDK<T> APMAEOAMGGN
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x53CC940", Offset = "0x53CB740", VA = "0x1853CC940")]
		public MLMFBBEKADL(Task<EHIFMMNJMNN<T>> JDEJDGHOHNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x53CC820", Offset = "0x53CB620", VA = "0x1853CC820", Slot = "10")]
		protected override void LPJFLBHHFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x53CC380", Offset = "0x53CB180", VA = "0x1853CC380")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(MLMFBBEKADL<>.JJOEIGGOCGF))]
		internal static Task<T> CNALGDDNHEI(Task<EHIFMMNJMNN<T>> JDEJDGHOHNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x53CC740", Offset = "0x53CB540", VA = "0x1853CC740")]
		[AsyncStateMachine(typeof(MLMFBBEKADL<>.FJLFCNMGJPA))]
		[CompilerGenerated]
		internal static Task KHCDFCGAJAL(Task<EHIFMMNJMNN<T>> JDEJDGHOHNF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class FCBGJBCONGB<TIn, TOut> : AHEBAANNNJJ<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct OKBKABMFCHH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x566C7D0", Offset = "0x566B5D0", VA = "0x18566C7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4B9CB30", Offset = "0x4B9B930", VA = "0x184B9CB30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly EHIFMMNJMNN<TIn> JAIPKOOJJOB;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> AMOBKEDPMBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override HMBEFKLHMDK<TOut> APMAEOAMGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4A45830", Offset = "0x4A44630", VA = "0x184A45830")]
		public FCBGJBCONGB(EHIFMMNJMNN<TIn> MKMNOHJGGKG, Func<TIn, TOut> KNPJDDKLIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4A45490", Offset = "0x4A44290", VA = "0x184A45490", Slot = "10")]
		protected override void LPJFLBHHFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4A45530", Offset = "0x4A44330", VA = "0x184A45530")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(FCBGJBCONGB<, >.OKBKABMFCHH))]
		internal static Task<TOut> NGOFMOBGNPB(Task<TIn> JPKEDFDKHPA, Func<TIn, TOut> KNPJDDKLIIH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3B00230", Offset = "0x3AFF030", VA = "0x183B00230")]
	public static EHIFMMNJMNN<T> LJAJAMKHAJN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3B00180", Offset = "0x3AFEF80", VA = "0x183B00180")]
	public static EHIFMMNJMNN<T> IIKJOABOCIM<T>(T BPINCJLADGC, [Optional] Action<T>? JDNGNIOHEPB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3776EB0", Offset = "0x3775CB0", VA = "0x183776EB0")]
	public static EHIFMMNJMNN<T> HFHKGNPKDJE<T>(Exception ANMGGEBBMLP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3776EB0", Offset = "0x3775CB0", VA = "0x183776EB0")]
	public static EHIFMMNJMNN<T> MMKOLFGLCKG<T>(Task<EHIFMMNJMNN<T>> JDEJDGHOHNF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x371BB90", Offset = "0x371A990", VA = "0x18371BB90")]
	public static EHIFMMNJMNN<TOut> MNFKMLBDMML<TOut, TIn>(EHIFMMNJMNN<TIn> BHHPJCAPOMD, Func<TIn, TOut> KNPJDDKLIIH) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class AHEBAANNNJJ<T> : EHIFMMNJMNN<T>, EPIKNCDFKGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string MPANGPCLGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly KPBNFJAGDEP FCCGLHJGGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool OMPJCPABCDP;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool PIFBNBODPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xCA88D0", Offset = "0xCA76D0", VA = "0x180CA88D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> AMOBKEDPMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract HMBEFKLHMDK<T> APMAEOAMGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4DBDB20", Offset = "0x4DBC920", VA = "0x184DBDB20")]
	public AHEBAANNNJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4DBD760", Offset = "0x4DBC560", VA = "0x184DBD760", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void LPJFLBHHFLB();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class GDIHEGKDMCK<TTask, T> : AHEBAANNNJJ<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HIMHIGDHLJN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public HIMHIGDHLJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x419D180", Offset = "0x419BF80", VA = "0x18419D180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x419D6D0", Offset = "0x419C4D0", VA = "0x18419D6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public GDIHEGKDMCK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public HIMHIGDHLJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4C2FDE0", Offset = "0x4C2EBE0", VA = "0x184C2FDE0")]
		[AsyncStateMachine(typeof(GDIHEGKDMCK<, >.HIMHIGDHLJN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> MGDABIMHDMH(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> JDEJDGHOHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource FMNLCBJFAGK;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> AMOBKEDPMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override HMBEFKLHMDK<T> APMAEOAMGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4B85150", Offset = "0x4B83F50", VA = "0x184B85150")]
	protected GDIHEGKDMCK(TTask JDEJDGHOHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4B84F00", Offset = "0x4B83D00", VA = "0x184B84F00", Slot = "10")]
	protected override void LPJFLBHHFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T FJMBDODPJBN(TTask LMDIKPOFAPC);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void EDHIJCBDECA();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class BLMCBPBGCNN<T> : AHEBAANNNJJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly MMLLOANHJIJ<Task<T>> OMHDCOEHKNE;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> AMOBKEDPMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4AD6820", Offset = "0x4AD5620", VA = "0x184AD6820", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override HMBEFKLHMDK<T> APMAEOAMGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6171870", Offset = "0x6170670", VA = "0x186171870")]
	public BLMCBPBGCNN(MMLLOANHJIJ<Task<T>> MOBEDKINCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6171850", Offset = "0x6170650", VA = "0x186171850", Slot = "10")]
	protected override void LPJFLBHHFLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class IFOCHHOLKBH
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName MBNKODOIKKE;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> IODEIGJAMGP;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7D620F0", Offset = "0x7D60EF0", VA = "0x187D620F0")]
	public static int OBBJOHEGFBE(this GHPGHPMCBFI LEMHLMFDNPJ, IncrementalHash CHKEMFCNGMN, byte[] JKDMJNHJJEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7D61D50", Offset = "0x7D60B50", VA = "0x187D61D50")]
	public static bool EMFDKKJKILP([CanBeNull] this GHPGHPMCBFI LEMHLMFDNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7D61A40", Offset = "0x7D60840", VA = "0x187D61A40")]
	public static bool EMFDKKJKILP([CanBeNull] this GHPGHPMCBFI LEMHLMFDNPJ, [Out] string NGENEEODOJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7D61DB0", Offset = "0x7D60BB0", VA = "0x187D61DB0")]
	public static bool EMFDKKJKILP([CanBeNull] this GHPGHPMCBFI LEMHLMFDNPJ, IncrementalHash CHKEMFCNGMN, byte[] JKDMJNHJJEI, [Out] string NGENEEODOJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7D62180", Offset = "0x7D60F80", VA = "0x187D62180")]
	private static bool PBKGJHEDAJI(byte[] OIADBJILJJO, Span<byte> BIENPAACEAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class KBFKEIBAGBJ
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7D624A0", Offset = "0x7D612A0", VA = "0x187D624A0")]
	public static int JBMGHPNNPHJ(HashAlgorithmName JEFHLHDKCLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x39C3BA0", Offset = "0x39C29A0", VA = "0x1839C3BA0")]
	public static int OBBJOHEGFBE<T>(this T EOBLEOIIMPK, byte[] HJDAPJNJCGD, IncrementalHash CHKEMFCNGMN, byte[] CAHDJAICNBH) where T : HMBFBKGPGPC
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HMBFBKGPGPC
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash CHKEMFCNGMN);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface GHPGHPMCBFI : HMBFBKGPGPC
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] CGNHDELFLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] EKOENGOGMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class NBFHCDEMAJJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool OJOCFCICBKL;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> BMMLIKKCFMC;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> LCDEPJCHKMM;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding OABPHAEBGCC;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> IBFLMLGPDAK;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3A95380", Offset = "0x3A94180", VA = "0x183A95380")]
	public static void GFBICFDDDAO<T>(this IncrementalHash MFDDGGPNOHA, [CanBeNull] T OFNOAHMACNB) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3A952F0", Offset = "0x3A940F0", VA = "0x183A952F0")]
	public static void BAKGACJIHFK<T>(this IncrementalHash MFDDGGPNOHA, [CanBeNull] T EOBLEOIIMPK) where T : HMBFBKGPGPC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3A95A70", Offset = "0x3A94870", VA = "0x183A95A70")]
	public static void OEAHIEKBKAF<T>(this IncrementalHash MFDDGGPNOHA, [CanBeNull] IList<T> BBJAIPOEMJH) where T : HMBFBKGPGPC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7D62800", Offset = "0x7D61600", VA = "0x187D62800")]
	private static bool BJNHIIHGPCC([CanBeNull] HMBFBKGPGPC EOBLEOIIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7D63160", Offset = "0x7D61F60", VA = "0x187D63160")]
	public static void NIEJHEGJEKD(this IncrementalHash CHKEMFCNGMN, string? GGNIPFCNHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7D62F90", Offset = "0x7D61D90", VA = "0x187D62F90")]
	public static void HDMILCNPBMB(this IncrementalHash CHKEMFCNGMN, long HOHGMPFKPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7D62A00", Offset = "0x7D61800", VA = "0x187D62A00")]
	public static void CGOMLEHPMNN(this IncrementalHash CHKEMFCNGMN, int MMIENOOLLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7D63570", Offset = "0x7D62370", VA = "0x187D63570")]
	public static void PDPFMPPNPDG(this IncrementalHash CHKEMFCNGMN, short GGBCGBPMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7D62DC0", Offset = "0x7D61BC0", VA = "0x187D62DC0")]
	public static void EFPHGACAGIN(this IncrementalHash CHKEMFCNGMN, byte PDFKIGFPBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7D62890", Offset = "0x7D61690", VA = "0x187D62890")]
	public static void BKKNHALDAHC(this IncrementalHash CHKEMFCNGMN, bool HGMDBCDKFKI, bool FAPIOBHNCKL = false, bool PFGAHHGBCCP = false, bool IPHAGDHAIHB = false, bool CMKEPKMDHDF = false, bool INODAJNPJFB = false, bool FPPOOILGOFB = false, bool OOOGNNHGECD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3A95440", Offset = "0x3A94240", VA = "0x183A95440")]
	public static void GILMEHJKCNO<T>(this IncrementalHash CHKEMFCNGMN, T JMDMECFGMML) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7D62BD0", Offset = "0x7D619D0", VA = "0x187D62BD0")]
	public static void CJDDNDKPPFK(this IncrementalHash CHKEMFCNGMN, float CLOCIACPGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7D62C30", Offset = "0x7D61A30", VA = "0x187D62C30")]
	public static void COEOHHHPDDO(this IncrementalHash CHKEMFCNGMN, ulong AFKGCENALND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7D62F30", Offset = "0x7D61D30", VA = "0x187D62F30")]
	public static void GODGDDBFAFI(this IncrementalHash CHKEMFCNGMN, uint GAOLFLLLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7D62ED0", Offset = "0x7D61CD0", VA = "0x187D62ED0")]
	public static void EHACBBMPBBE(this IncrementalHash CHKEMFCNGMN, ushort MHKCBKKBPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7D62C90", Offset = "0x7D61A90", VA = "0x187D62C90")]
	public static void EFMBPPNHDEH(this IncrementalHash CHKEMFCNGMN, Vector3 NDEALLOFJDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class BOHMNAOIBCF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D610E0", Offset = "0x7D5FEE0", VA = "0x187D610E0")]
	public BOHMNAOIBCF(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class CIMPMFCODDL
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void DGCMJHMBLGL(ushort NPJONOKFOAG, ushort EEFAJLACGCG, ushort DEEKAONOMCO, ushort JPIPPGLODGC);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void GEKIICKKOJP(ushort EPGGDNLDOND, ushort IFFNNLJCGLF);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void GKJMKOKMIPD();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort DEDCCACHNPD = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected CIMPMFCODDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class OACLABGFDOH<T> : CIMPMFCODDL where T : OACLABGFDOH<T>.JIFMGOFDPPL
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface JIFMGOFDPPL
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		GEKIICKKOJP BIIALOOIAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		GEKIICKKOJP FNHEOFLNCHN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		GKJMKOKMIPD FFLBNIDHCME
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> GGGIBNGFGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private GKJMKOKMIPD JJKBIPGAGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GKJMKOKMIPD IJGKDHFPBCD;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool DIEPNNDGBED
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0C50", VA = "0x180AC1E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA0B690", Offset = "0xA0A490", VA = "0x180A0B690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort OEDHKJBGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x55F5180", Offset = "0x55F3F80", VA = "0x1855F5180")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x55F4D30", Offset = "0x55F3B30", VA = "0x1855F4D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort EIKFGJANDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x55F4E10", Offset = "0x55F3C10", VA = "0x1855F4E10")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x55F4090", Offset = "0x55F2E90", VA = "0x1855F4090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort OMKOCJJDHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xDF46A0", Offset = "0xDF34A0", VA = "0x180DF46A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xDF47C0", Offset = "0xDF35C0", VA = "0x180DF47C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort PNNNBANFNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x55F50B0", Offset = "0x55F3EB0", VA = "0x1855F50B0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x55F5170", Offset = "0x55F3F70", VA = "0x1855F5170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool AFFJKLCDANA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x17F49C0", Offset = "0x17F37C0", VA = "0x1817F49C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool JPAJCCBNNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xEC4340", Offset = "0xEC3140", VA = "0x180EC4340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DGCMJHMBLGL LFBJGAHPKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x55F40A0", Offset = "0x55F2EA0", VA = "0x1855F40A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x55F4BE0", Offset = "0x55F39E0", VA = "0x1855F4BE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x55F4C80", Offset = "0x55F3A80", VA = "0x1855F4C80")]
	private T FOLCFAFOMOD(ushort COKIOJKKKLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x55F4D50", Offset = "0x55F3B50", VA = "0x1855F4D50")]
	private T HPFICJILGOD(ushort COKIOJKKKLC, ushort CLNJCJFHENI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x55F41A0", Offset = "0x55F2FA0", VA = "0x1855F41A0")]
	protected T EOBNBJAOAOB(uint LHJGPEPMAMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x55F5190", Offset = "0x55F3F90", VA = "0x1855F5190")]
	protected OACLABGFDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x55F4200", Offset = "0x55F3000", VA = "0x1855F4200")]
	public void EONJMIAAJPN(ushort IPCBMOEAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x55F4350", Offset = "0x55F3150", VA = "0x1855F4350")]
	public void EONJMIAAJPN(ushort IPCBMOEAJHF, ushort LABPAONINFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x55F4240", Offset = "0x55F3040", VA = "0x1855F4240", Slot = "4")]
	protected virtual void EONJMIAAJPN(uint LPBLMJKIKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x55F43B0", Offset = "0x55F31B0", VA = "0x1855F43B0")]
	protected void FEEBODFDJIK(uint LPBLMJKIKMK, uint DMIGJBDEOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x55F50C0", Offset = "0x55F3EC0", VA = "0x1855F50C0")]
	protected void NFPNFNIBEHN(ushort COKIOJKKKLC, ushort CLNJCJFHENI, T JNOIIIFBOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x55F4140", Offset = "0x55F2F40", VA = "0x1855F4140")]
	private void DJNCADLNMHE(uint LHJGPEPMAMM, T JNOIIIFBOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x55F4E30", Offset = "0x55F3C30", VA = "0x1855F4E30")]
	protected void KNFLPMCOILK(float GNNOPFAGLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x55F4E20", Offset = "0x55F3C20", VA = "0x1855F4E20")]
	protected uint KENJHBMDBGP(ushort COKIOJKKKLC, ushort CLNJCJFHENI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x55F50A0", Offset = "0x55F3EA0", VA = "0x1855F50A0")]
	protected ushort LIMKPJMOLJP(uint LNOIKAOOMCB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x55F4D40", Offset = "0x55F3B40", VA = "0x1855F4D40")]
	protected ushort HHBLJBBDJMM(uint LNOIKAOOMCB)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class DIPOCMONOPJ : OACLABGFDOH<DIPOCMONOPJ.LMHDPKNJCAM>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class LMHDPKNJCAM : JIFMGOFDPPL
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public GEKIICKKOJP BIIALOOIAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public GEKIICKKOJP FNHEOFLNCHN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public GKJMKOKMIPD FFLBNIDHCME
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LMHDPKNJCAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7D61460", Offset = "0x7D60260", VA = "0x187D61460")]
	public void PLDBIDKGPPO(ushort FHNGCKBAMGC, GEKIICKKOJP PKDIPOMNKMD, GEKIICKKOJP OIMCBEOOAJI, GKJMKOKMIPD FAIFBCCMHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D61380", Offset = "0x7D60180", VA = "0x187D61380")]
	public void PLDBIDKGPPO(ushort COKIOJKKKLC, ushort CLNJCJFHENI, GEKIICKKOJP PKDIPOMNKMD, GEKIICKKOJP OIMCBEOOAJI, GKJMKOKMIPD FAIFBCCMHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D61330", Offset = "0x7D60130", VA = "0x187D61330")]
	public void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D61540", Offset = "0x7D60340", VA = "0x187D61540")]
	protected DIPOCMONOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class FGEPILAAHDB : DIPOCMONOPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool HBOGFMBJOAD;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xC3A4D0", Offset = "0xC392D0", VA = "0x180C3A4D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD17420", Offset = "0xD16220", VA = "0x180D17420")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D617F0", Offset = "0x7D605F0", VA = "0x187D617F0")]
	public void IANLJFINMMK(ushort AFJMDBEBFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D61790", Offset = "0x7D60590", VA = "0x187D61790")]
	public void IANLJFINMMK(ushort AFJMDBEBFFD, ushort HOOECLNCBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D61540", Offset = "0x7D60340", VA = "0x187D61540")]
	public FGEPILAAHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class GMCCEOKCIMF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class PEFBEGMDGFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode FPFHIDBMBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode BOGJJGPKPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AEFMCNOBBLM EALBMDJEHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<AEFMCNOBBLM> GALNLFCHJMM;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PEFBEGMDGFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct AEFMCNOBBLM : IComparable<AEFMCNOBBLM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int FBACJIPNPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant JPBHONGEGJA;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x16B0730", Offset = "0x16AF530", VA = "0x1816B0730")]
		public AEFMCNOBBLM(int FBACJIPNPNF, TClaimant JPBHONGEGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4BA47A0", Offset = "0x4BA35A0", VA = "0x184BA47A0")]
		public bool ACCHNOGNJCO([In] AEFMCNOBBLM HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4800", Offset = "0x4BA3600", VA = "0x184BA4800")]
		public bool CAIPGJGNFEL([In] AEFMCNOBBLM HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4810", Offset = "0x4BA3610", VA = "0x184BA4810", Slot = "4")]
		public int CompareTo(AEFMCNOBBLM HBLONCAMFLG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4820", Offset = "0x4BA3620", VA = "0x184BA4820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum KMMOCAKPHMM
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class MHDBEFBKIJO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public GMCCEOKCIMF<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public MHDBEFBKIJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x53C33A0", Offset = "0x53C21A0", VA = "0x1853C33A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x53C3580", Offset = "0x53C2380", VA = "0x1853C3580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x53C3480", Offset = "0x53C2280", VA = "0x1853C3480", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x460E0E0", Offset = "0x460CEE0", VA = "0x18460E0E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly JJHFHBONIDO<PEFBEGMDGFM> FLDMDKPMILD;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly JJHFHBONIDO<List<AEFMCNOBBLM>> MABOGLBLLBB;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int OHHGBIJLNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> MLMAHGOIKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, PEFBEGMDGFM> OHHLAJCODMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private KMMOCAKPHMM FIAIMOBPCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DLKCDFLPOJC(TNode BINEDJHADMC);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void LCMNMHGIBLM(TNode BINEDJHADMC, TClaimant DEGLKEMJFHK, TClaimant FBICAMKLONP);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4BD5AA0", Offset = "0x4BD48A0", VA = "0x184BD5AA0")]
	public GMCCEOKCIMF(KMMOCAKPHMM FIAIMOBPCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4BD4560", Offset = "0x4BD3360", VA = "0x184BD4560")]
	public void FNIKINAOJBG(TNode BINEDJHADMC, TNode JDMAEDJOOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4BD4F50", Offset = "0x4BD3D50", VA = "0x184BD4F50")]
	public void JFNHDHKKGCK(TClaimant JPBHONGEGJA, TNode OKGAICEMMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4BD42E0", Offset = "0x4BD30E0", VA = "0x184BD42E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4BD56D0", Offset = "0x4BD44D0", VA = "0x184BD56D0")]
	private void LLFLFBGNOHA(TClaimant JPBHONGEGJA, TNode CAAKNIOKKEM, TNode OKGAICEMMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4BD44F0", Offset = "0x4BD32F0", VA = "0x184BD44F0")]
	private int FMNOHBDJJMJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4BD5230", Offset = "0x4BD4030", VA = "0x184BD5230")]
	private void JKIEJPOLPPK(TClaimant JPBHONGEGJA, TNode HNOAIIKIFMH, TNode GDJNLDEHAHA, int JIFBEKLIENE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4BD4620", Offset = "0x4BD3420", VA = "0x184BD4620")]
	private void FNMCEJEGEHK(AEFMCNOBBLM KIBBFGHGDPI, PEFBEGMDGFM DCBFDJKHMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4BD46F0", Offset = "0x4BD34F0", VA = "0x184BD46F0")]
	private void FNNNOJJCPAG(TClaimant JPBHONGEGJA, TNode HNOAIIKIFMH, TNode GDJNLDEHAHA, int JIFBEKLIENE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4BD57A0", Offset = "0x4BD45A0", VA = "0x184BD57A0")]
	private void NOKGEDJCLPJ(AEFMCNOBBLM KIBBFGHGDPI, TNode BINEDJHADMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4BD50D0", Offset = "0x4BD3ED0", VA = "0x184BD50D0")]
	private void JJOBGBOFKFN(AEFMCNOBBLM KIBBFGHGDPI, PEFBEGMDGFM DCBFDJKHMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4BD5580", Offset = "0x4BD4380", VA = "0x184BD5580")]
	private void JPOKEMPNIJL(PEFBEGMDGFM DCBFDJKHMOJ, bool IFFLOMBHMBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4BD4BE0", Offset = "0x4BD39E0", VA = "0x184BD4BE0")]
	private void IKFGKILBDFN(PEFBEGMDGFM DCBFDJKHMOJ, TNode JDMAEDJOOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4BD4AF0", Offset = "0x4BD38F0", VA = "0x184BD4AF0")]
	[IteratorStateMachine(typeof(GMCCEOKCIMF<, >.MHDBEFBKIJO))]
	private IEnumerable<TNode> ICJPMLEHDLI(TNode HNOAIIKIFMH, TNode GDJNLDEHAHA, bool IAFAMGDAHMH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4BD49E0", Offset = "0x4BD37E0", VA = "0x184BD49E0")]
	private PEFBEGMDGFM GMPHBLJEEFH(TNode BINEDJHADMC, TNode BOGJJGPKPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4BD4160", Offset = "0x4BD2F60", VA = "0x184BD4160")]
	private PEFBEGMDGFM DCNEMKMJEII(TNode BINEDJHADMC, TNode BOGJJGPKPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4BD3FA0", Offset = "0x4BD2DA0", VA = "0x184BD3FA0")]
	private void BLBKDNMNDGC(PEFBEGMDGFM DCBFDJKHMOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DDIMECLAJGG<T> : IEnumerable<DDIMECLAJGG<T>.MDOIDPCDIBD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct MDOIDPCDIBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T OAIIHELJHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int GLAOLHCPLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class LLOOCIJLHIK : IEnumerator<MDOIDPCDIBD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private DDIMECLAJGG<T> MNMCPCDGAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int GLAOLHCPLLG;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x461CF20", Offset = "0x461BD20", VA = "0x18461CF20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public MDOIDPCDIBD CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x51A9E80", Offset = "0x51A8C80", VA = "0x1851A9E80", Slot = "4")]
			get
			{
				return default(MDOIDPCDIBD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x51A9E40", Offset = "0x51A8C40", VA = "0x1851A9E40")]
		public LLOOCIJLHIK(DDIMECLAJGG<T> MNMCPCDGAHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x51A9DC0", Offset = "0x51A8BC0", VA = "0x1851A9DC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x46809D0", Offset = "0x467F7D0", VA = "0x1846809D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x118AF40", Offset = "0x1189D40", VA = "0x18118AF40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct JGDJLPLOEJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool IELCIOEDFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T OAIIHELJHLG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int NIMGFDKIBGD = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> MHFHAKKMLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private JGDJLPLOEJB[] NPOLMPAGPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int EHCMNGANINB;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int IIJADJGICGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xD521D0", Offset = "0xD50FD0", VA = "0x180D521D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xF5E9F0", Offset = "0xF5D7F0", VA = "0x180F5E9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x41B40C0", Offset = "0x41B2EC0", VA = "0x1841B40C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6AED560", Offset = "0x6AEC360", VA = "0x186AED560")]
	public DDIMECLAJGG(int KIOMCEJDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6AED140", Offset = "0x6AEBF40", VA = "0x186AED140")]
	public DDIMECLAJGG(MDOIDPCDIBD[] NJLEHIMFBJM, bool JMINIGNMCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC510", Offset = "0x6AEB310", VA = "0x186AEC510")]
	public int MGLBCKHIKEJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC6C0", Offset = "0x6AEB4C0", VA = "0x186AEC6C0")]
	private int OKEOGHPMGKM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC670", Offset = "0x6AEB470", VA = "0x186AEC670", Slot = "6")]
	protected virtual uint NKCBJEINICA(uint CHKEMFCNGMN, T OAIIHELJHLG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC350", Offset = "0x6AEB150", VA = "0x186AEC350")]
	public bool DGGFCBDMMBJ(T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC490", Offset = "0x6AEB290", VA = "0x186AEC490")]
	public int DMIBNEEMCLH(T OAIIHELJHLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC2E0", Offset = "0x6AEB0E0", VA = "0x186AEC2E0")]
	public T ALLJPLIMGBA(int GLAOLHCPLLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6AECAF0", Offset = "0x6AEB8F0", VA = "0x186AECAF0")]
	public bool PBGCPDIDMGE(T OAIIHELJHLG, bool LJBDPBEDMDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6AECDF0", Offset = "0x6AEBBF0", VA = "0x186AECDF0")]
	public bool PBGCPDIDMGE(T OAIIHELJHLG, int GLAOLHCPLLG, bool LJBDPBEDMDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC5D0", Offset = "0x6AEB3D0", VA = "0x186AEC5D0")]
	private int NJADNGKMIBG(int AJOJFAFFHHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6AED0A0", Offset = "0x6AEBEA0", VA = "0x186AED0A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6AED0A0", Offset = "0x6AEBEA0", VA = "0x186AED0A0", Slot = "4")]
	private IEnumerator<MDOIDPCDIBD> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class JJHFHBONIDO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> CEJJHFEJOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> OMNAABHCNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int IEEPKFNFIJF;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF7B0", Offset = "0x4FBE5B0", VA = "0x184FBF7B0")]
	public static JJHFHBONIDO<T> NMEKPHLDLFO(int KIOMCEJDGPM = 0, int IEEPKFNFIJF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF6C0", Offset = "0x4FBE4C0", VA = "0x184FBF6C0")]
	public static JJHFHBONIDO<T> NAMJCNEEGLA(int KIOMCEJDGPM = 0, int IEEPKFNFIJF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFB90", Offset = "0x4FBE990", VA = "0x184FBFB90")]
	public JJHFHBONIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF980", Offset = "0x4FBE780", VA = "0x184FBF980")]
	public JJHFHBONIDO(int KIOMCEJDGPM, int IEEPKFNFIJF = int.MaxValue, bool LEJMIELLNMA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF180", Offset = "0x4FBDF80", VA = "0x184FBF180")]
	public T IGFEPLMMLKP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF8A0", Offset = "0x4FBE6A0", VA = "0x184FBF8A0")]
	public void OJKDNIEEGBG(T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF350", Offset = "0x4FBE150", VA = "0x184FBF350")]
	private void JAAMHPEBBBO(T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF140", Offset = "0x4FBDF40", VA = "0x184FBF140")]
	private void EDLDGELEFAH(T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4FBEFB0", Offset = "0x4FBDDB0", VA = "0x184FBEFB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF450", Offset = "0x4FBE250", VA = "0x184FBF450")]
	private void MEHNNIAHPKO(IEnumerable<T> BGBLHEHBHCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LBIHHEPFFOE<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> HLNAGBKDKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T ELNFCDLOAED;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T KNPGIDAEIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5153C70", Offset = "0x5152A70", VA = "0x185153C70")]
	public bool PKOECEEOIDM(T OAIIHELJHLG, int FBACJIPNPNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4FB7F90", Offset = "0x4FB6D90", VA = "0x184FB7F90")]
	public bool DGJFOFCPLFN(int FBACJIPNPNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5153540", Offset = "0x5152340", VA = "0x185153540")]
	public T DLLFKBNKEDF(int JAPFJMHIGCJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5153A90", Offset = "0x5152890", VA = "0x185153A90")]
	private bool OFKDLNIPCMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5153980", Offset = "0x5152780", VA = "0x185153980")]
	public bool GNFCCDJDLII(int FBACJIPNPNF, [Out] T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4FBA580", Offset = "0x4FB9380", VA = "0x184FBA580")]
	public LBIHHEPFFOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class FACKMBCHAMB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct PHIGCPHCKAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T COJGBJGNJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int JIMKPCCKHFP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<PHIGCPHCKAB> AKAPGMCKHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T PENLALEONKL;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x41B40C0", Offset = "0x41B2EC0", VA = "0x1841B40C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4A427D0", Offset = "0x4A415D0", VA = "0x184A427D0")]
	public bool CIMEKDDIMAF(T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4A425A0", Offset = "0x4A413A0", VA = "0x184A425A0")]
	public void AIKICPLLADB(T OAIIHELJHLG, int FBACJIPNPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4A42D40", Offset = "0x4A41B40", VA = "0x184A42D40")]
	public bool FKCGDELNEED(T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4A42730", Offset = "0x4A41530", VA = "0x184A42730")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4A42FC0", Offset = "0x4A41DC0", VA = "0x184A42FC0")]
	public T GLKMMCGAHAN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4A43060", Offset = "0x4A41E60", VA = "0x184A43060")]
	protected void IOMPIMHFBDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4A43360", Offset = "0x4A42160", VA = "0x184A43360")]
	public FACKMBCHAMB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7D64080", Offset = "0x7D62E80", VA = "0x187D64080")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7D64350", Offset = "0x7D63150", VA = "0x187D64350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7D64260", Offset = "0x7D63060", VA = "0x187D64260")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7D63FD0", Offset = "0x7D62DD0", VA = "0x187D63FD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7D642A0", Offset = "0x7D630A0", VA = "0x187D642A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7D641B0", Offset = "0x7D62FB0", VA = "0x187D641B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7D63F40", Offset = "0x7D62D40", VA = "0x187D63F40")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5994E20", Offset = "0x5993C20", VA = "0x185994E20", Slot = "4")]
		public virtual T HHKANJDBKJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface JOPLIBHBGMO
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache GGFKFGHCGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public struct GMPENCJAJHK<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> COKPAJOONAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool FMMNKOONKFJ;

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1803FC0", Offset = "0x1802DC0", VA = "0x181803FC0")]
			public GMPENCJAJHK(List<Component> COKPAJOONAO, bool FMMNKOONKFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x4BD6B40", Offset = "0x4BD5940", VA = "0x184BD6B40")]
			public PCNOPKJFFOG<T> PHEMDOOJNPF()
			{
				return default(PCNOPKJFFOG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x4BD6BA0", Offset = "0x4BD59A0", VA = "0x184BD6BA0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x4BD6BA0", Offset = "0x4BD59A0", VA = "0x184BD6BA0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct PCNOPKJFFOG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> COKPAJOONAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool FMMNKOONKFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int GLAOLHCPLLG;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T CKHLHELFBCM
			{
				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x576ED70", Offset = "0x576DB70", VA = "0x18576ED70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x576ED00", Offset = "0x576DB00", VA = "0x18576ED00", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x576ED40", Offset = "0x576DB40", VA = "0x18576ED40")]
			public PCNOPKJFFOG(List<Component> COKPAJOONAO, bool FMMNKOONKFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x576EC40", Offset = "0x576DA40", VA = "0x18576EC40", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x576EC50", Offset = "0x576DA50", VA = "0x18576EC50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x46701E0", Offset = "0x466EFE0", VA = "0x1846701E0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7D65D80", Offset = "0x7D64B80", VA = "0x187D65D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7D65B70", Offset = "0x7D64970", VA = "0x187D65B70")]
		private void IANLJFINMMK(GameObject CIEOFCKLMHA, bool PGBCKJJIOAA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7D65AE0", Offset = "0x7D648E0", VA = "0x187D65AE0")]
		public static void IANLJFINMMK(GameObject CIEOFCKLMHA, ToolHierarchyCache EHNDDIAIEKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7D65CE0", Offset = "0x7D64AE0", VA = "0x187D65CE0")]
		public void NHKKIIAGFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6D30", Offset = "0x3CF5B30", VA = "0x183CF6D30")]
		public void EHGCOPPFHAI<T>(Action<T> CFDGGKIIHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7030", Offset = "0x3CF5E30", VA = "0x183CF7030")]
		public T MDNOMBEJJCD<T>(bool FMMNKOONKFJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6F70", Offset = "0x3CF5D70", VA = "0x183CF6F70")]
		public GMPENCJAJHK<T> KCOHCJNJCJE<T>(bool FMMNKOONKFJ = false) where T : class
		{
			return default(GMPENCJAJHK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7D65660", Offset = "0x7D64460", VA = "0x187D65660")]
		public List<Component> DGGCCJMLBEL(Type AAFMBEEMJAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7D659F0", Offset = "0x7D647F0", VA = "0x187D659F0", Slot = "4")]
		public bool Equals(ToolHierarchyCache AJEEBBBAOKG, ToolHierarchyCache GJPKMHAOJHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7D65A70", Offset = "0x7D64870", VA = "0x187D65A70", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GLEBGNJJOHG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class JFEDHEINLLA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int KIOMCEJDGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int MFENAHCHDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> HMGJLPMKAIL;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4AD6820", Offset = "0x4AD5620", VA = "0x184AD6820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T MKDDBDEOMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4FA3FC0", Offset = "0x4FA2DC0", VA = "0x184FA3FC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T LJAFFMGGNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x4FA4540", Offset = "0x4FA3340", VA = "0x184FA4540")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T KIHALBIPEAG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x4FA43C0", Offset = "0x4FA31C0", VA = "0x184FA43C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x4FA45E0", Offset = "0x4FA33E0", VA = "0x184FA45E0")]
	public JFEDHEINLLA(int KIOMCEJDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3D00", Offset = "0x4FA2B00", VA = "0x184FA3D00")]
	public void AIKICPLLADB(T OFPCHCCGIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4FA4170", Offset = "0x4FA2F70", VA = "0x184FA4170")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4FA42C0", Offset = "0x4FA30C0", VA = "0x184FA42C0")]
	public void IHLNLONCGEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x4FA4260", Offset = "0x4FA3060", VA = "0x184FA4260")]
	public void IDLPIDEGFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4FA43B0", Offset = "0x4FA31B0", VA = "0x184FA43B0")]
	public void ILDCLMFOIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4FA41D0", Offset = "0x4FA2FD0", VA = "0x184FA41D0")]
	public List<T> FMNHFCJAHEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class BPFJNBJNHNK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct DKKIMFFPPBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int JIMKPCCKHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T COJGBJGNJFM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, DKKIMFFPPBN> HLNAGBKDKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> EHCBCJCPNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T ELNFCDLOAED;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T KNPGIDAEIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xD55D30", Offset = "0xD54B30", VA = "0x180D55D30", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6181680", Offset = "0x6180480", VA = "0x186181680", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool ELLLHODOKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x61810B0", Offset = "0x617FEB0", VA = "0x1861810B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object IMNHLMPGGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x61833D0", Offset = "0x61821D0", VA = "0x1861833D0")]
	public bool PKOECEEOIDM(T OAIIHELJHLG, object JLFLGDNCANL, int FBACJIPNPNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6181110", Offset = "0x617FF10", VA = "0x186181110")]
	public bool DGJFOFCPLFN(object JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x61811D0", Offset = "0x617FFD0", VA = "0x1861811D0")]
	public bool GNFCCDJDLII(object JLFLGDNCANL, [Out] T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4C1DC80", Offset = "0x4C1CA80", VA = "0x184C1DC80")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6181980", Offset = "0x6180780", VA = "0x186181980")]
	private bool OFKDLNIPCMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6183670", Offset = "0x6182470", VA = "0x186183670")]
	public BPFJNBJNHNK()
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
