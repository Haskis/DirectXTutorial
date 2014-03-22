using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
namespace TutorialDirectX
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true);
            InitializeComponent();
            Initialize();
            SetCamera();
            SetFloor();
            SetBase();
            SetElevatorBase();  
        }


        private void SetCamera()
        {
            float x = (float)this.Width / (float)this.Height;
            device.Transform.Projection = Matrix.PerspectiveFovLH((float)Math.PI / 4, x, 30f, 200f);

            device.Transform.View = Matrix.LookAtLH(new Vector3(0, 0, 1), new Vector3(0, 0, 0), new Vector3(0, -1, 0))*
                                    Matrix.RotationX((float) xRot)*
                                    Matrix.RotationY((float) yRot)*
                                    Matrix.RotationZ((float) zRot)*
                                    Matrix.Translation(0,0, 120);
        }


        private void SetFloor()
        {
            floor[0].Position = new Vector3(-30,-30,0);
            floor[0].Color = Color.Gray.ToArgb();

            floor[1].Position = new Vector3(-30,30,0);
            floor[1].Color = Color.Gray.ToArgb();

            floor[2].Position = new Vector3(30, -30, 0);
            floor[2].Color = Color.Gray.ToArgb();

            floor[3].Position = new Vector3(30, 30, 0);
            floor[3].Color = Color.Gray.ToArgb();
        }

        private void SetBase()
        {
            walls[0].Position = new Vector3(-5, 5, 0);
            walls[0].Color = Color.Blue.ToArgb();
            walls[1].Position = new Vector3(-5, 5, 20);
            walls[1].Color = Color.Blue.ToArgb();

            //Wall 1
            walls[2].Position = new Vector3(5, 5, 0);
            walls[2].Color = Color.Blue.ToArgb();
            walls[3].Position = new Vector3(5, 5, 20);
            walls[3].Color = Color.Blue.ToArgb();

            //Wall 2
            walls[4].Position = new Vector3(5, -5, 0);
            walls[4].Color = Color.Blue.ToArgb();
            walls[5].Position = new Vector3(5, -5, 20);
            walls[5].Color = Color.Blue.ToArgb();

            //Wall 3
            walls[6].Position = new Vector3(-5, -5, 0);
            walls[6].Color = Color.Blue.ToArgb();
            walls[7].Position = new Vector3(-5, -5, 20);
            walls[7].Color = Color.Blue.ToArgb();
            
            //Wall 4
            walls[8].Position = new Vector3(-5, 5, 0);
            walls[8].Color = Color.Blue.ToArgb();
            walls[9].Position = new Vector3(-5, 5, 20);
            walls[9].Color = Color.Blue.ToArgb();

           
        }

        private void SetElevatorBase()
        {
            wallsMoving[0].Position = new Vector3(-4, 4, 0);
            wallsMoving[0].Color = Color.Green.ToArgb();
            wallsMoving[1].Position = new Vector3(-4, 4, 22);
            wallsMoving[1].Color = Color.Green.ToArgb();

            //Wall 1
            wallsMoving[2].Position = new Vector3(4, 4, 0);
            wallsMoving[2].Color = Color.Green.ToArgb();
            wallsMoving[3].Position = new Vector3(4, 4, 22);
            wallsMoving[3].Color = Color.Green.ToArgb();

            //Wall 2
            wallsMoving[4].Position = new Vector3(4, -4, 0);
            wallsMoving[4].Color = Color.Green.ToArgb();
            wallsMoving[5].Position = new Vector3(4, -4, 22);
            wallsMoving[5].Color = Color.Green.ToArgb();

            //Wall 3
            wallsMoving[6].Position = new Vector3(-4, -4, 0);
            wallsMoving[6].Color = Color.Green.ToArgb();
            wallsMoving[7].Position = new Vector3(-4, -4, 22);
            wallsMoving[7].Color = Color.Green.ToArgb();

            //Wall 4
            wallsMoving[8].Position = new Vector3(-4, 4, 0);
            wallsMoving[8].Color = Color.Green.ToArgb();
            wallsMoving[9].Position = new Vector3(-4, 4, 22);
            wallsMoving[9].Color = Color.Green.ToArgb();

            //Stage base
            stage[0].Position = new Vector3(-7,-7,22);
            stage[0].Color = Color.Chartreuse.ToArgb();
            stage[1].Position = new Vector3(-7, 7, 22);
            stage[1].Color = Color.Chartreuse.ToArgb();

            //Stage 1
            stage[2].Position = new Vector3(7, -7, 22);
            stage[2].Color = Color.Chartreuse.ToArgb();
            stage[3].Position = new Vector3(7, 7, 22);
            stage[3].Color = Color.Chartreuse.ToArgb();
        }

        private void Initialize()
        {
            PresentParameters pp = new PresentParameters();
            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard;
            pp.EnableAutoDepthStencil = true;
            pp.AutoDepthStencilFormat = DepthFormat.D16;
            device = new Device(0,DeviceType.Reference,this,CreateFlags.SoftwareVertexProcessing, pp);

            Light light = new Light();
            light.Type = LightType.Point;
            
   
        //light.Diffuse = Color(0.5f, 0.5f, 0.5f, 1.0f);
        //light.Position = Vector3(0.0f, 5.0f, 0.0f);
        //light.Range = 300.0f;    // a range of 100
        //light.Attenuation0 = 0.0f;    // no constant inverse attenuation
        //light.Attenuation1 = 0.125f;    // only .125 inverse attenuation
        //light.Attenuation2 = 0.0f;    // no square inverse attenuation



            device.RenderState.Lighting = false;//true;

            device.Lights[0].Type = LightType.Directional;
            device.Lights[0].Diffuse = Color.White;
            device.Lights[0].Direction = new Vector3(1, 1, -1);
            device.Lights[0].Update();
            device.Lights[0].Enabled = true;

            device.Lights[1].Type = LightType.Directional;
            device.Lights[1].Diffuse = Color.White;
            device.Lights[1].Direction = new Vector3(-1, -1, -1);
            device.Lights[1].Update();
            device.Lights[1].Enabled = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SetFloor();
            //SetTriangle();
            SetCamera();

            device.Clear(ClearFlags.Target, Color.Black, 1, 0);
            device.Clear(ClearFlags.ZBuffer, Color.Black, 1, 0);

            

            device.RenderState.ZBufferEnable = true;
            device.BeginScene();

            device.RenderState.CullMode = Cull.None;
            device.VertexFormat = CustomVertex.PositionColored.Format;

            device.Transform.World = Matrix.Translation(0, 0, 0);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 2, floor);

            //Bases
            device.Transform.World = Matrix.Translation(0, 0, 0);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 8, walls);

            device.Transform.World = Matrix.Translation(20, 0, 0);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 8, walls);

            device.Transform.World = Matrix.Translation(0, 20, 0);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 8, walls);

            device.Transform.World = Matrix.Translation(20, 20, 0);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 8, walls);

            //Moving
            device.Transform.World = Matrix.Translation(0, 0, (float) elevator1Height);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip,8,wallsMoving);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip,2,stage);

            device.Transform.World = Matrix.Translation(20, 0, (float)elevator2Height);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 8, wallsMoving);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 2, stage);

            device.Transform.World = Matrix.Translation(0, 20, (float)elevator3Height);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 8, wallsMoving);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 2, stage);

            device.Transform.World = Matrix.Translation(20, 20, (float)elevator4Height);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 8, wallsMoving);
            device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 2, stage);
                device.EndScene();
            device.Present();
            this.Invalidate();
            angle += 0.05f;
            base.OnPaint(e);
        }

        Form3 myForm = new Form3();

        private double xRot;
        private double yRot;
        private double zRot;


        private double elevator1Height;
        private double elevator2Height;
        private double elevator3Height;
        private double elevator4Height;
        private Device device;
        private float angle;
        private CustomVertex.PositionColored[] floor = new CustomVertex.PositionColored[4];
        private CustomVertex.PositionColored[] walls = new CustomVertex.PositionColored[10];
        
        private CustomVertex.PositionColored[] wallsMoving = new CustomVertex.PositionColored[10];
        private CustomVertex.PositionColored[] stage = new CustomVertex.PositionColored[4];

        private void hScrollBarYRot_Scroll(object sender, ScrollEventArgs e)
        {
            this.yRot = e.NewValue/20.0;
        }

        private void hScrollBarZRot_Scroll(object sender, ScrollEventArgs e)
        {
            this.zRot = e.NewValue/20.0;
        }
        private void hScrollBarXRot_Scroll(object sender, ScrollEventArgs e)
        {
            this.xRot = e.NewValue /20.0;
        }
     

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.elevator1Height = e.NewValue / 5.0;
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            this.elevator2Height = e.NewValue/5.0;
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            this.elevator3Height = e.NewValue/5.0;
        }

        private void vScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            this.elevator4Height = e.NewValue/5.0;
        }

       

    }
}
