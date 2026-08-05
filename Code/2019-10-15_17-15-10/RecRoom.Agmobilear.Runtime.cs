using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ARFaceCoefficients : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ARFaceCoefficients()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ARSelfieController : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ARSelfieController()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RequireComponent(typeof(ARFace))]
public class ARKitBlendShapeVisualizer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private float m_CoefficientScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private SkinnedMeshRenderer m_SkinnedMeshRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ARFace m_Face;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float coefficientScale
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3219F0", Offset = "0x3205F0", VA = "0x1803219F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x536720", Offset = "0x535320", VA = "0x180536720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public SkinnedMeshRenderer skinnedMeshRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x31A680", Offset = "0x319280", VA = "0x18031A680")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24C8450", Offset = "0x24C7050", VA = "0x1824C8450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24C7EA0", Offset = "0x24C6AA0", VA = "0x1824C7EA0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24C7EF0", Offset = "0x24C6AF0", VA = "0x1824C7EF0")]
	private void CreateFeatureBlendMapping()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x24C8200", Offset = "0x24C6E00", VA = "0x1824C8200")]
	private void SetVisible(bool visible)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24C8350", Offset = "0x24C6F50", VA = "0x1824C8350")]
	private void UpdateVisibility()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24C8060", Offset = "0x24C6C60", VA = "0x1824C8060")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x24C7FA0", Offset = "0x24C6BA0", VA = "0x1824C7FA0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x24C8120", Offset = "0x24C6D20", VA = "0x1824C8120")]
	private void OnSystemStateChanged(ARSessionStateChangedEventArgs eventArgs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24C8130", Offset = "0x24C6D30", VA = "0x1824C8130")]
	private void OnUpdated(ARFaceUpdatedEventArgs eventArgs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24C8290", Offset = "0x24C6E90", VA = "0x1824C8290")]
	private void UpdateFaceFeatures()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24C8440", Offset = "0x24C7040", VA = "0x1824C8440")]
	public ARKitBlendShapeVisualizer()
	{
	}
}
namespace Cpp2IlInjected;

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
